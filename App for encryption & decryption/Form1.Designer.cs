namespace App_for_encryption___decryption
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtInput = new TextBox();
            btnEncrypt = new Button();
            btnDecrypt = new Button();
            txtOutput = new TextBox();
            txtKey = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // txtInput
            // 
            txtInput.Location = new Point(23, 67);
            txtInput.Multiline = true;
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(982, 181);
            txtInput.TabIndex = 1;
            // 
            // btnEncrypt
            // 
            btnEncrypt.BackColor = SystemColors.MenuHighlight;
            btnEncrypt.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEncrypt.Location = new Point(280, 254);
            btnEncrypt.Name = "btnEncrypt";
            btnEncrypt.Size = new Size(92, 44);
            btnEncrypt.TabIndex = 2;
            btnEncrypt.Text = "Encrypt";
            btnEncrypt.UseVisualStyleBackColor = false;
            btnEncrypt.Click += btnEncrypt_Click;
            // 
            // btnDecrypt
            // 
            btnDecrypt.BackColor = Color.SandyBrown;
            btnDecrypt.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDecrypt.Location = new Point(644, 254);
            btnDecrypt.Name = "btnDecrypt";
            btnDecrypt.Size = new Size(96, 44);
            btnDecrypt.TabIndex = 4;
            btnDecrypt.Text = "Decrypt";
            btnDecrypt.UseVisualStyleBackColor = false;
            btnDecrypt.Click += btnDecrypt_Click;
            // 
            // txtOutput
            // 
            txtOutput.Location = new Point(23, 304);
            txtOutput.Multiline = true;
            txtOutput.Name = "txtOutput";
            txtOutput.ReadOnly = true;
            txtOutput.Size = new Size(982, 181);
            txtOutput.TabIndex = 5;
            // 
            // txtKey
            // 
            txtKey.Location = new Point(148, 41);
            txtKey.Name = "txtKey";
            txtKey.Size = new Size(857, 23);
            txtKey.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(23, 34);
            label1.Name = "label1";
            label1.Size = new Size(119, 30);
            label1.TabIndex = 7;
            label1.Text = "Enter Key:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(474, 497);
            label2.Name = "label2";
            label2.Size = new Size(73, 21);
            label2.TabIndex = 8;
            label2.Text = "DONE!!!!";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1028, 524);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtKey);
            Controls.Add(txtOutput);
            Controls.Add(btnDecrypt);
            Controls.Add(btnEncrypt);
            Controls.Add(txtInput);
            Name = "Form1";
            Text = "Encryptor and Decryptor App";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtInput;
        private Button btnEncrypt;
        private Button btnDecrypt;
        private TextBox txtOutput;
        private TextBox txtKey;
        private Label label1;
        private Label label2;
    }
}
