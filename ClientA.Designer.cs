namespace PlayFair
{
    partial class ClientA
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
            this.txtEncrypted = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnClientB = new System.Windows.Forms.Button();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPlainText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDepth = new System.Windows.Forms.NumericUpDown();
            this.cbxProgramType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lblServerStatus = new System.Windows.Forms.Label();
            this.btnAcceptConnection = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.txtDepth)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtEncrypted
            // 
            this.txtEncrypted.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.txtEncrypted.Location = new System.Drawing.Point(346, 523);
            this.txtEncrypted.Multiline = true;
            this.txtEncrypted.Name = "txtEncrypted";
            this.txtEncrypted.Size = new System.Drawing.Size(372, 67);
            this.txtEncrypted.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(67, 536);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(273, 38);
            this.label3.TabIndex = 14;
            this.label3.Text = "Encrypted Text:";
            // 
            // btnClientB
            // 
            this.btnClientB.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientB.Location = new System.Drawing.Point(430, 403);
            this.btnClientB.Name = "btnClientB";
            this.btnClientB.Size = new System.Drawing.Size(249, 62);
            this.btnClientB.TabIndex = 13;
            this.btnClientB.Text = "Send To Client B";
            this.btnClientB.UseVisualStyleBackColor = true;
            this.btnClientB.Click += new System.EventHandler(this.btnClientB_Click);
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncrypt.Location = new System.Drawing.Point(94, 403);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(313, 62);
            this.btnEncrypt.TabIndex = 12;
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // txtKey
            // 
            this.txtKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKey.Location = new System.Drawing.Point(332, 303);
            this.txtKey.Multiline = true;
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(372, 67);
            this.txtKey.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(99, 320);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 50);
            this.label2.TabIndex = 10;
            this.label2.Text = "Keyword:";
            // 
            // txtPlainText
            // 
            this.txtPlainText.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlainText.Location = new System.Drawing.Point(332, 222);
            this.txtPlainText.Multiline = true;
            this.txtPlainText.Name = "txtPlainText";
            this.txtPlainText.Size = new System.Drawing.Size(372, 67);
            this.txtPlainText.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 50);
            this.label1.TabIndex = 8;
            this.label1.Text = "Plain Text:";
            // 
            // txtDepth
            // 
            this.txtDepth.Location = new System.Drawing.Point(332, 336);
            this.txtDepth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtDepth.Name = "txtDepth";
            this.txtDepth.Size = new System.Drawing.Size(372, 20);
            this.txtDepth.TabIndex = 17;
            this.txtDepth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDepth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtDepth.Visible = false;
            // 
            // cbxProgramType
            // 
            this.cbxProgramType.FormattingEnabled = true;
            this.cbxProgramType.Items.AddRange(new object[] {
            "PlayFair",
            "Rail Fence"});
            this.cbxProgramType.Location = new System.Drawing.Point(332, 153);
            this.cbxProgramType.Name = "cbxProgramType";
            this.cbxProgramType.Size = new System.Drawing.Size(317, 21);
            this.cbxProgramType.TabIndex = 18;
            this.cbxProgramType.Text = "PlayFair";
            this.cbxProgramType.SelectedIndexChanged += new System.EventHandler(this.cbxProgramType_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(114, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(201, 31);
            this.label4.TabIndex = 19;
            this.label4.Text = "Program Type:";
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.Black;
            this.btnStart.Location = new System.Drawing.Point(165, 83);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(159, 23);
            this.btnStart.TabIndex = 20;
            this.btnStart.Text = "Start Server";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(6, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 29);
            this.label5.TabIndex = 21;
            this.label5.Text = "Server Status:";
            // 
            // lblServerStatus
            // 
            this.lblServerStatus.AutoSize = true;
            this.lblServerStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServerStatus.ForeColor = System.Drawing.Color.Green;
            this.lblServerStatus.Location = new System.Drawing.Point(174, 38);
            this.lblServerStatus.Name = "lblServerStatus";
            this.lblServerStatus.Size = new System.Drawing.Size(0, 24);
            this.lblServerStatus.TabIndex = 22;
            // 
            // btnAcceptConnection
            // 
            this.btnAcceptConnection.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcceptConnection.ForeColor = System.Drawing.Color.Black;
            this.btnAcceptConnection.Location = new System.Drawing.Point(364, 83);
            this.btnAcceptConnection.Name = "btnAcceptConnection";
            this.btnAcceptConnection.Size = new System.Drawing.Size(159, 23);
            this.btnAcceptConnection.TabIndex = 23;
            this.btnAcceptConnection.Text = "Accept Connection";
            this.btnAcceptConnection.UseVisualStyleBackColor = true;
            this.btnAcceptConnection.Click += new System.EventHandler(this.btnAcceptConnection_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnStart);
            this.groupBox1.Controls.Add(this.btnAcceptConnection);
            this.groupBox1.Controls.Add(this.lblServerStatus);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Blue;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(746, 119);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Server Status";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(559, 83);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 23);
            this.button1.TabIndex = 24;
            this.button1.Text = "Send Mode";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ClientA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 618);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbxProgramType);
            this.Controls.Add(this.txtDepth);
            this.Controls.Add(this.txtEncrypted);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnClientB);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.txtKey);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPlainText);
            this.Controls.Add(this.label1);
            this.Location = new System.Drawing.Point(20, 200);
            this.Name = "ClientA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Client A";
            ((System.ComponentModel.ISupportInitialize)(this.txtDepth)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEncrypted;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnClientB;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPlainText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown txtDepth;
        private System.Windows.Forms.ComboBox cbxProgramType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblServerStatus;
        private System.Windows.Forms.Button btnAcceptConnection;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
    }
}

