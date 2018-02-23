namespace PlayFair
{
    partial class ClientB
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
            this.txtDecrypted = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelE = new System.Windows.Forms.Label();
            this.lblEncryptedText = new System.Windows.Forms.Label();
            this.txtDepth = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnRecieveMessage = new System.Windows.Forms.Button();
            this.lblClientStatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtDepth)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDecrypted
            // 
            this.txtDecrypted.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.txtDecrypted.Location = new System.Drawing.Point(284, 423);
            this.txtDecrypted.Multiline = true;
            this.txtDecrypted.Name = "txtDecrypted";
            this.txtDecrypted.Size = new System.Drawing.Size(372, 67);
            this.txtDecrypted.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 439);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(235, 34);
            this.label3.TabIndex = 19;
            this.label3.Text = "Decrypted Text:";
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecrypt.Location = new System.Drawing.Point(200, 324);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(372, 62);
            this.btnDecrypt.TabIndex = 18;
            this.btnDecrypt.Text = "Decrypt";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // txtKey
            // 
            this.txtKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKey.Location = new System.Drawing.Point(284, 228);
            this.txtKey.Multiline = true;
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(372, 50);
            this.txtKey.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(67, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 50);
            this.label2.TabIndex = 16;
            this.label2.Text = "Keyword:";
            // 
            // labelE
            // 
            this.labelE.AutoSize = true;
            this.labelE.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelE.Location = new System.Drawing.Point(42, 148);
            this.labelE.Name = "labelE";
            this.labelE.Size = new System.Drawing.Size(238, 34);
            this.labelE.TabIndex = 21;
            this.labelE.Text = "Encrypted Text:";
            // 
            // lblEncryptedText
            // 
            this.lblEncryptedText.AutoSize = true;
            this.lblEncryptedText.Font = new System.Drawing.Font("Modern No. 20", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEncryptedText.ForeColor = System.Drawing.Color.Green;
            this.lblEncryptedText.Location = new System.Drawing.Point(284, 151);
            this.lblEncryptedText.Name = "lblEncryptedText";
            this.lblEncryptedText.Size = new System.Drawing.Size(0, 31);
            this.lblEncryptedText.TabIndex = 22;
            // 
            // txtDepth
            // 
            this.txtDepth.Location = new System.Drawing.Point(284, 244);
            this.txtDepth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtDepth.Name = "txtDepth";
            this.txtDepth.Size = new System.Drawing.Size(372, 20);
            this.txtDepth.TabIndex = 23;
            this.txtDepth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDepth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtDepth.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnConnect);
            this.groupBox1.Controls.Add(this.btnRecieveMessage);
            this.groupBox1.Controls.Add(this.lblClientStatus);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Blue;
            this.groupBox1.Location = new System.Drawing.Point(12, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(746, 100);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Client Status";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(359, 65);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 29);
            this.button1.TabIndex = 24;
            this.button1.Text = "App Mode";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(6, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 29);
            this.label5.TabIndex = 21;
            this.label5.Text = "Client Status:";
            // 
            // btnConnect
            // 
            this.btnConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnect.ForeColor = System.Drawing.Color.Black;
            this.btnConnect.Location = new System.Drawing.Point(165, 65);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(159, 29);
            this.btnConnect.TabIndex = 20;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnRecieveMessage
            // 
            this.btnRecieveMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecieveMessage.ForeColor = System.Drawing.Color.Black;
            this.btnRecieveMessage.Location = new System.Drawing.Point(568, 65);
            this.btnRecieveMessage.Name = "btnRecieveMessage";
            this.btnRecieveMessage.Size = new System.Drawing.Size(159, 29);
            this.btnRecieveMessage.TabIndex = 23;
            this.btnRecieveMessage.Text = "Recieve Message";
            this.btnRecieveMessage.UseVisualStyleBackColor = true;
            this.btnRecieveMessage.Click += new System.EventHandler(this.btnRecieveMessage_Click);
            // 
            // lblClientStatus
            // 
            this.lblClientStatus.AutoSize = true;
            this.lblClientStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientStatus.ForeColor = System.Drawing.Color.Green;
            this.lblClientStatus.Location = new System.Drawing.Point(174, 38);
            this.lblClientStatus.Name = "lblClientStatus";
            this.lblClientStatus.Size = new System.Drawing.Size(0, 24);
            this.lblClientStatus.TabIndex = 22;
            // 
            // ClientB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 512);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtDepth);
            this.Controls.Add(this.lblEncryptedText);
            this.Controls.Add(this.labelE);
            this.Controls.Add(this.txtDecrypted);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.txtKey);
            this.Controls.Add(this.label2);
            this.Location = new System.Drawing.Point(1000, 200);
            this.Name = "ClientB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Client B";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ClientB_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.txtDepth)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDecrypted;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelE;
        private System.Windows.Forms.Label lblEncryptedText;
        private System.Windows.Forms.NumericUpDown txtDepth;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnRecieveMessage;
        private System.Windows.Forms.Label lblClientStatus;
        private System.Windows.Forms.Button button1;
    }
}