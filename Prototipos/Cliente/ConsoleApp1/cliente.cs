using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace ConsoleApp1
{
    class cliente
    {
        TcpClient clientSocket = new TcpClient();
        NetworkStream serverStream = default;
        string readData = null;
        string allMessages = "";

        public void conectarAoServidor(string ip, string nomeUser)
        {
            readData = "Conectando ao servidor...";
            msg();
            clientSocket.Connect(ip, 8888);
            serverStream = clientSocket.GetStream();
            byte[] outStream = Encoding.ASCII.GetBytes(nomeUser + "$");
            serverStream.Write(outStream, 0, outStream.Length);
            serverStream.Flush();
            Thread ctThread = new Thread(getMessage);
            ctThread.Start();
        }
        private void getMessage()
        {
            while (true)
            {
                serverStream = clientSocket.GetStream();
                int buffSize = 0;
                buffSize = clientSocket.ReceiveBufferSize;
                byte[] inStream = new byte[buffSize];
                serverStream.Read(inStream, 0, buffSize);
                string returndata = Encoding.ASCII.GetString(inStream);
                readData = "" + returndata;
                msg();
            }
        }

        private void msg()
        {
            allMessages = allMessages + Environment.NewLine + " >> " + readData;
        }

        public void enviarMensagem(string mensagem)
        {
            byte[] outStream = Encoding.ASCII.GetBytes(mensagem + "$");
            serverStream.Write(outStream, 0, outStream.Length);
            serverStream.Flush();
        }
    }
}
