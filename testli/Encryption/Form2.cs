using Encryption;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPN_16_Sifreleme
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public void sifrelenmisVeri(string txt)
        {
            txtPlain.Text = txt;
        }
        public void spnChecked()
        {
            checkBoxSPN.Checked = true;
        }

        #region Turkish characters Replace
        public string non_T_Chars(string text)
        {
            text = text.Replace("İ", "I");
            text = text.Replace("ı", "i");
            text = text.Replace("Ğ", "G");
            text = text.Replace("ğ", "g");
            text = text.Replace("Ö", "O");
            text = text.Replace("ö", "o");
            text = text.Replace("Ü", "U");
            text = text.Replace("ü", "u");
            text = text.Replace("Ş", "S");
            text = text.Replace("ş", "s");
            text = text.Replace("Ç", "C");
            text = text.Replace("ç", "c");
            return text;
        }
        #endregion
        public void btn_Encrypt_Click(object sender, EventArgs e)
        {
          
            txtPlain.Text = non_T_Chars(txtPlain.Text);
            if (txtPlain.Text == "") { MessageBox.Show("Text cannot be empty.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }   // can't be empty
            else if (txtKey.Text == "") { MessageBox.Show("Key cannot be empty.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
            else if (txtKey.Text.Length != 8) { MessageBox.Show("Key must be 8 characters long.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
            else
            {
                labelPText.Text = "Plain Text";
                labelCipher.Text = "Encrypted Text";
                if (checkBoxSPN.Checked == true)
                {
                    if (txtPlain.Text.Length % 2 == 1) { txtPlain.Text += " "; } // Spn works with 2 character in every steps, so Text must be even characters long.                                                                              // uzunluk çift değilse sona boşluk eklenir.
                    else
                    {
                        SPN_encryption spn = new SPN_encryption(txtPlain.Text, txtKey.Text);
                        txtCipher.Text = spn.encrypt();
                    }
                }
                else if (checkBoxSHA.Checked == true)
                {
                    SHA_encryption sha = new SHA_encryption(txtPlain.Text);
                    txtCipher.Text = sha.encrypt();
                }
                else if (checkBoxSPN.Checked == false && checkBoxSHA.Checked == false) { MessageBox.Show("Select the encryption method you want ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }

            }
        
    }

        public void btn_Decrypt_Click(object sender, EventArgs e)
        {
            if (txtPlain.Text == "") { MessageBox.Show("Cannot be empty.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
            else if (txtKey.Text == "") { MessageBox.Show("Key cannot be empty.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
            else if (txtKey.Text.Length != 8) { MessageBox.Show("Key must be 8 character.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
            else
            {
                labelPText.Text = "Encrypted Text";
                labelCipher.Text = "Decrypted Text";

                if (checkBoxSPN.Checked == true)
                {
                    SPN_encryption spn = new SPN_encryption(txtKey.Text);
                    txtCipher.Text = spn.decrypt(txtPlain.Text);
                }
                else if (checkBoxSHA.Checked == true) MessageBox.Show("SHA cannot be decrypted. ");
                else if (checkBoxSPN.Checked == false && checkBoxSHA.Checked == false) { MessageBox.Show("Select the decryption method you want ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
            }
        }

        public void checkBoxSPN_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSPN.Checked == true)
            {
                checkBoxSHA.Checked = false;
            }
        }

        public void checkBoxSHA_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBoxSHA.Checked == true)
            {
                checkBoxSPN.Checked = false;
            }
        }

        public void txtKey_TextChanged(object sender, EventArgs e)
        {

        }

        public void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
