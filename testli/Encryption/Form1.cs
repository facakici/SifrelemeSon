using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

/*
 Ömer Faruk Yılmaz          5.12.2021
 (Yazılım Sınama ödevi 1.kısmı) 
 
 
 */


namespace Encryption
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region Form_Load
        private void Form1_Load(object sender, EventArgs e)
        {
            ToolTip explanation = new ToolTip();
            explanation.ToolTipTitle = "Instruction!";
            explanation.ToolTipIcon = ToolTipIcon.Warning;
            explanation.IsBalloon = true;

            explanation.SetToolTip(btn_Decrypt, "Paste the decrypted text into the top textbox before clicking the button ");
        }
        #endregion


        #region ChecBoxes
        private void checkBoxSPN_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSPN.Checked == true)
            {
                checkBoxSHA.Checked = false;
            }
            
        }

        private void checkBoxSHA_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSHA.Checked == true)
            {
                checkBoxSPN.Checked = false;
            }
        }
        #endregion


        #region Encrytption Buttons
        private void btn_Encrypt_Click(object sender, EventArgs e)
        {
            txtPlain.Text = non_T_Chars(txtPlain.Text);
            if (txtPlain.Text == "") { MessageBox.Show("Text cannot be empty.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }   // can't be empty
            else if(txtKey.Text == "") { MessageBox.Show("Key cannot be empty.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
            else if (txtKey.Text.Length != 8) { MessageBox.Show("Key must be 8 characters long.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
            else
            {
                labelPText.Text = "Plain Text";
                labelCipher.Text = "Encrypted Text";
                if (checkBoxSPN.Checked == true )
                {
                    if (txtPlain.Text.Length % 2 == 1) { txtPlain.Text += " "; } // Spn works with 2 character in every steps, so Text must be even characters long.                                                                              // uzunluk çift değilse sona boşluk eklenir.
                    else
                    {
                        SPN_encryption spn = new SPN_encryption(txtPlain.Text, txtKey.Text);
                        txtCipher.Text = spn.encrypt();
                        if(Program.oForm2==null)
                             Program.oForm2 = new SPN_16_Sifreleme.Form2();
                        if (Application.OpenForms["Form2"] == null)
                            Program.oForm2.Show();
                        Program.oForm2.sifrelenmisVeri(txtCipher.Text);
                        Program.oForm2.spnChecked();
                        //Program.oForm2.btn_Decrypt_Click(sender, e);
                    }
                }
                else if (checkBoxSHA.Checked == true )
                {
                    SHA_encryption sha = new SHA_encryption(txtPlain.Text);
                    txtCipher.Text = sha.encrypt();
                    if (Program.oForm2 == null)
                        Program.oForm2 = new SPN_16_Sifreleme.Form2();
                    if (Application.OpenForms["Form2"] == null)
                        Program.oForm2.Show();
                    Program.oForm2.sifrelenmisVeri(txtCipher.Text);
                    
                }
                else if (checkBoxSPN.Checked == false && checkBoxSHA.Checked == false) { MessageBox.Show("Select the encryption method you want ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }

            }
        }

        private void btn_Decrypt_Click(object sender, EventArgs e)
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
        #endregion


        #region Turkish characters Replace
        private string non_T_Chars(string text)
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

        private void txtCipher_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPlain_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelPText_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtKey_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
