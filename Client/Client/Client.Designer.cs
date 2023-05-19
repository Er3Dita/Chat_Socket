namespace Client
{
    partial class Client
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnConnect = new System.Windows.Forms.Button();
            this.txtBoxSend = new System.Windows.Forms.TextBox();
            this.labelChatTitle = new System.Windows.Forms.Label();
            this.txtBoxChat = new System.Windows.Forms.TextBox();
            this.btn_Send = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnConnect
            // 
            this.btnConnect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConnect.Location = new System.Drawing.Point(601, 101);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(79, 25);
            this.btnConnect.TabIndex = 14;
            this.btnConnect.Text = "Connettiti";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click_1);
            // 
            // txtBoxSend
            // 
            this.txtBoxSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxSend.Location = new System.Drawing.Point(384, 390);
            this.txtBoxSend.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxSend.Multiline = true;
            this.txtBoxSend.Name = "txtBoxSend";
            this.txtBoxSend.Size = new System.Drawing.Size(297, 25);
            this.txtBoxSend.TabIndex = 13;
            // 
            // labelChatTitle
            // 
            this.labelChatTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelChatTitle.AutoSize = true;
            this.labelChatTitle.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelChatTitle.Location = new System.Drawing.Point(501, 106);
            this.labelChatTitle.Name = "labelChatTitle";
            this.labelChatTitle.Size = new System.Drawing.Size(34, 16);
            this.labelChatTitle.TabIndex = 12;
            this.labelChatTitle.Text = "Chat";
            // 
            // txtBoxChat
            // 
            this.txtBoxChat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxChat.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtBoxChat.Location = new System.Drawing.Point(384, 128);
            this.txtBoxChat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxChat.Multiline = true;
            this.txtBoxChat.Name = "txtBoxChat";
            this.txtBoxChat.ReadOnly = true;
            this.txtBoxChat.Size = new System.Drawing.Size(297, 245);
            this.txtBoxChat.TabIndex = 11;
            // 
            // btn_Send
            // 
            this.btn_Send.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Send.Location = new System.Drawing.Point(584, 421);
            this.btn_Send.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Send.Name = "btn_Send";
            this.btn_Send.Size = new System.Drawing.Size(97, 32);
            this.btn_Send.TabIndex = 10;
            this.btn_Send.Text = "Invia";
            this.btn_Send.UseVisualStyleBackColor = true;
            this.btn_Send.Click += new System.EventHandler(this.btn_Send_Click_1);
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.txtBoxSend);
            this.Controls.Add(this.labelChatTitle);
            this.Controls.Add(this.txtBoxChat);
            this.Controls.Add(this.btn_Send);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Client";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox txtBoxSend;
        private System.Windows.Forms.Label labelChatTitle;
        private System.Windows.Forms.TextBox txtBoxChat;
        private System.Windows.Forms.Button btn_Send;
    }
}

