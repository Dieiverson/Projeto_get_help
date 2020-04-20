using System;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        TcpClient clientSocket = new TcpClient();
        NetworkStream serverStream = default;
        string readData = null;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

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
            if (InvokeRequired)
            {
                Invoke(new MethodInvoker(msg));
            }
            else
            {
                rich_Msgs.Text = rich_Msgs.Text + Environment.NewLine + " >> " + readData;
            }                
        }

        private void Btn_ConnectServer_Click(object sender, EventArgs e)
        {
            readData = "Conectando ao servidor...";
            msg();
            clientSocket.Connect(txt_ipServer.Text, 8888);
            serverStream = clientSocket.GetStream();
            byte[] outStream = Encoding.ASCII.GetBytes(txt_nomeUsuario.Text + "$");
            serverStream.Write(outStream, 0, outStream.Length);
            serverStream.Flush();
            Thread ctThread = new Thread(getMessage);
            ctThread.Start();
        }

        private void Btn_EnviarMsg_Click(object sender, EventArgs e)
        {
            byte[] outStream = Encoding.ASCII.GetBytes(txtMsgDigitada.Text + "$");
            serverStream.Write(outStream, 0, outStream.Length);
            serverStream.Flush();
        }
    }
}

