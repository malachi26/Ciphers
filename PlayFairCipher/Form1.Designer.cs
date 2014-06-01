namespace PlayFairCipher
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
            this.rtbOutput = new System.Windows.Forms.RichTextBox();
            this.txtKeyPhrase = new System.Windows.Forms.TextBox();
            this.lblKeyPhrase = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // rtbOutput
            // 
            this.rtbOutput.Location = new System.Drawing.Point(132, 103);
            this.rtbOutput.Name = "rtbOutput";
            this.rtbOutput.Size = new System.Drawing.Size(162, 96);
            this.rtbOutput.TabIndex = 0;
            this.rtbOutput.Text = "";
            // 
            // txtKeyPhrase
            // 
            this.txtKeyPhrase.Location = new System.Drawing.Point(132, 34);
            this.txtKeyPhrase.Name = "txtKeyPhrase";
            this.txtKeyPhrase.Size = new System.Drawing.Size(100, 20);
            this.txtKeyPhrase.TabIndex = 1;
            this.txtKeyPhrase.Text = "Playfaire";
            // 
            // lblKeyPhrase
            // 
            this.lblKeyPhrase.AutoSize = true;
            this.lblKeyPhrase.Location = new System.Drawing.Point(13, 34);
            this.lblKeyPhrase.Name = "lblKeyPhrase";
            this.lblKeyPhrase.Size = new System.Drawing.Size(60, 13);
            this.lblKeyPhrase.TabIndex = 2;
            this.lblKeyPhrase.Text = "Key phrase";
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(13, 60);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(50, 13);
            this.lblMessage.TabIndex = 3;
            this.lblMessage.Text = "Message";
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(132, 60);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(146, 20);
            this.txtMessage.TabIndex = 4;
            this.txtMessage.Text = "put your message here";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 103);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(57, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Encrypt";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(16, 230);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(278, 20);
            this.textBox1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 262);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.lblKeyPhrase);
            this.Controls.Add(this.txtKeyPhrase);
            this.Controls.Add(this.rtbOutput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbOutput;
        private System.Windows.Forms.TextBox txtKeyPhrase;
        private System.Windows.Forms.Label lblKeyPhrase;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

