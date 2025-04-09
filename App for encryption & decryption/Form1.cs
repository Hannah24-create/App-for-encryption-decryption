using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using static App_for_encryption___decryption.EncryptionMain;




namespace App_for_encryption___decryption
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //private void textBox2_TextChanged(object sender, EventArgs e)
        //{

        //}

        //private void Form1_Load(object sender, EventArgs e)
        //{

        //}

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            try
            {
                // Get user input and keys
                string input = txtInput.Text;
                string key = txtKey.Text;

                // Basic validation
                if (string.IsNullOrWhiteSpace(input))
                {
                    MessageBox.Show("Please enter some text to encrypt.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(key))
                {
                    MessageBox.Show("Please enter a key.");
                    return;
                }

                // Create an instance of the EncryptionMain class
                EncryptionManager main = new EncryptionManager();

                // Encrypt the text using the class method
                string encryptedText = main.EncryptText(input, key);

                // Show the result
                txtOutput.Text = encryptedText;
            }
            catch (Exception ex)
            {
                // Friendly error message
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            string cipherText = txtInput.Text;
            string key = txtKey.Text;

            if (string.IsNullOrEmpty(cipherText) || string.IsNullOrEmpty(key))
            {
                MessageBox.Show("Please enter both ciphertext and key.");
                return;
            }

            string decryptedText = DecryptionMain.Decrypt(cipherText, key);
            txtOutput.Text = decryptedText;
        }

    }
}


