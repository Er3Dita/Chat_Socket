namespace Server
{
    partial class Server
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
            this.btnNewConnection = new System.Windows.Forms.Button();
            this.txtBoxSend = new System.Windows.Forms.TextBox();
            this.labelChatTitle = new System.Windows.Forms.Label();
            this.txtBoxChat = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnNewConnection
            // 
            this.btnNewConnection.Location = new System.Drawing.Point(584, 119);
            this.btnNewConnection.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNewConnection.Name = "btnNewConnection";
            this.btnNewConnection.Size = new System.Drawing.Size(97, 25);
            this.btnNewConnection.TabIndex = 18;
            this.btnNewConnection.Text = "Avvia Server";
            this.btnNewConnection.UseVisualStyleBackColor = true;
            this.btnNewConnection.Click += new System.EventHandler(this.btnNewConnection_Click);
            // 
            // txtBoxSend
            // 
            this.txtBoxSend.Location = new System.Drawing.Point(384, 409);
            this.txtBoxSend.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxSend.Multiline = true;
            this.txtBoxSend.Name = "txtBoxSend";
            this.txtBoxSend.ReadOnly = true;
            this.txtBoxSend.Size = new System.Drawing.Size(297, 25);
            this.txtBoxSend.TabIndex = 17;
            // 
            // labelChatTitle
            // 
            this.labelChatTitle.AutoSize = true;
            this.labelChatTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelChatTitle.ForeColor = System.Drawing.Color.White;
            this.labelChatTitle.Location = new System.Drawing.Point(519, 128);
            this.labelChatTitle.Name = "labelChatTitle";
            this.labelChatTitle.Size = new System.Drawing.Size(34, 16);
            this.labelChatTitle.TabIndex = 16;
            this.labelChatTitle.Text = "Chat";
            // 
            // txtBoxChat
            // 
            this.txtBoxChat.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtBoxChat.ForeColor = System.Drawing.Color.Black;
            this.txtBoxChat.Location = new System.Drawing.Point(384, 146);
            this.txtBoxChat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxChat.Multiline = true;
            this.txtBoxChat.Name = "txtBoxChat";
            this.txtBoxChat.ReadOnly = true;
            this.txtBoxChat.Size = new System.Drawing.Size(297, 245);
            this.txtBoxChat.TabIndex = 15;
            // 
            // Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnNewConnection);
            this.Controls.Add(this.txtBoxSend);
            this.Controls.Add(this.labelChatTitle);
            this.Controls.Add(this.txtBoxChat);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Server";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNewConnection;
        private System.Windows.Forms.TextBox txtBoxSend;
        private System.Windows.Forms.Label labelChatTitle;
        private System.Windows.Forms.TextBox txtBoxChat;
    }
}

