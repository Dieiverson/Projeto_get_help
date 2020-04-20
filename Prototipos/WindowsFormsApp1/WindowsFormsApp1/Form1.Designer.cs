namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_nomeUsuario = new System.Windows.Forms.TextBox();
            this.lbl_NomeUsuario = new System.Windows.Forms.Label();
            this.btn_ConnectServer = new System.Windows.Forms.Button();
            this.rich_Msgs = new System.Windows.Forms.RichTextBox();
            this.txtMsgDigitada = new System.Windows.Forms.TextBox();
            this.btn_EnviarMsg = new System.Windows.Forms.Button();
            this.txt_ipServer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_nomeUsuario
            // 
            this.txt_nomeUsuario.Location = new System.Drawing.Point(164, 56);
            this.txt_nomeUsuario.Name = "txt_nomeUsuario";
            this.txt_nomeUsuario.Size = new System.Drawing.Size(152, 20);
            this.txt_nomeUsuario.TabIndex = 0;
            // 
            // lbl_NomeUsuario
            // 
            this.lbl_NomeUsuario.AutoSize = true;
            this.lbl_NomeUsuario.Location = new System.Drawing.Point(23, 59);
            this.lbl_NomeUsuario.Name = "lbl_NomeUsuario";
            this.lbl_NomeUsuario.Size = new System.Drawing.Size(138, 13);
            this.lbl_NomeUsuario.TabIndex = 1;
            this.lbl_NomeUsuario.Text = "Digite seu nome de usuário:";
            // 
            // btn_ConnectServer
            // 
            this.btn_ConnectServer.Location = new System.Drawing.Point(164, 82);
            this.btn_ConnectServer.Name = "btn_ConnectServer";
            this.btn_ConnectServer.Size = new System.Drawing.Size(152, 23);
            this.btn_ConnectServer.TabIndex = 2;
            this.btn_ConnectServer.Text = "Conectar Ao Servidor";
            this.btn_ConnectServer.UseVisualStyleBackColor = true;
            this.btn_ConnectServer.Click += new System.EventHandler(this.Btn_ConnectServer_Click);
            // 
            // rich_Msgs
            // 
            this.rich_Msgs.Location = new System.Drawing.Point(26, 109);
            this.rich_Msgs.Name = "rich_Msgs";
            this.rich_Msgs.Size = new System.Drawing.Size(290, 217);
            this.rich_Msgs.TabIndex = 3;
            this.rich_Msgs.Text = "";
            // 
            // txtMsgDigitada
            // 
            this.txtMsgDigitada.Location = new System.Drawing.Point(26, 332);
            this.txtMsgDigitada.Name = "txtMsgDigitada";
            this.txtMsgDigitada.Size = new System.Drawing.Size(184, 20);
            this.txtMsgDigitada.TabIndex = 4;
            // 
            // btn_EnviarMsg
            // 
            this.btn_EnviarMsg.Location = new System.Drawing.Point(216, 330);
            this.btn_EnviarMsg.Name = "btn_EnviarMsg";
            this.btn_EnviarMsg.Size = new System.Drawing.Size(100, 23);
            this.btn_EnviarMsg.TabIndex = 5;
            this.btn_EnviarMsg.Text = "Enviar Mensagem";
            this.btn_EnviarMsg.UseVisualStyleBackColor = true;
            this.btn_EnviarMsg.Click += new System.EventHandler(this.Btn_EnviarMsg_Click);
            // 
            // txt_ipServer
            // 
            this.txt_ipServer.Location = new System.Drawing.Point(164, 9);
            this.txt_ipServer.Name = "txt_ipServer";
            this.txt_ipServer.Size = new System.Drawing.Size(152, 20);
            this.txt_ipServer.TabIndex = 6;
            this.txt_ipServer.Text = "192.168.0.5";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "IP do servidor:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_ipServer);
            this.Controls.Add(this.btn_EnviarMsg);
            this.Controls.Add(this.txtMsgDigitada);
            this.Controls.Add(this.rich_Msgs);
            this.Controls.Add(this.btn_ConnectServer);
            this.Controls.Add(this.lbl_NomeUsuario);
            this.Controls.Add(this.txt_nomeUsuario);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_nomeUsuario;
        private System.Windows.Forms.Label lbl_NomeUsuario;
        private System.Windows.Forms.Button btn_ConnectServer;
        private System.Windows.Forms.RichTextBox rich_Msgs;
        private System.Windows.Forms.TextBox txtMsgDigitada;
        private System.Windows.Forms.Button btn_EnviarMsg;
        private System.Windows.Forms.TextBox txt_ipServer;
        private System.Windows.Forms.Label label1;
    }
}

