
namespace Encryption
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.labelPText = new System.Windows.Forms.Label();
            this.txtPlain = new System.Windows.Forms.TextBox();
            this.checkBoxSPN = new System.Windows.Forms.CheckBox();
            this.checkBoxSHA = new System.Windows.Forms.CheckBox();
            this.labelCipher = new System.Windows.Forms.Label();
            this.txtCipher = new System.Windows.Forms.TextBox();
            this.btn_Encrypt = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.btn_Decrypt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelPText
            // 
            this.labelPText.AutoSize = true;
            this.labelPText.Location = new System.Drawing.Point(34, 20);
            this.labelPText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPText.Name = "labelPText";
            this.labelPText.Size = new System.Drawing.Size(54, 13);
            this.labelPText.TabIndex = 0;
            this.labelPText.Text = "Plain Text";
            this.labelPText.Click += new System.EventHandler(this.labelPText_Click);
            // 
            // txtPlain
            // 
            this.txtPlain.BackColor = System.Drawing.Color.Honeydew;
            this.txtPlain.Location = new System.Drawing.Point(29, 45);
            this.txtPlain.Margin = new System.Windows.Forms.Padding(2);
            this.txtPlain.MinimumSize = new System.Drawing.Size(76, 82);
            this.txtPlain.Multiline = true;
            this.txtPlain.Name = "txtPlain";
            this.txtPlain.Size = new System.Drawing.Size(222, 82);
            this.txtPlain.TabIndex = 1;
            this.txtPlain.TextChanged += new System.EventHandler(this.txtPlain_TextChanged);
            // 
            // checkBoxSPN
            // 
            this.checkBoxSPN.AutoSize = true;
            this.checkBoxSPN.Location = new System.Drawing.Point(65, 193);
            this.checkBoxSPN.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxSPN.Name = "checkBoxSPN";
            this.checkBoxSPN.Size = new System.Drawing.Size(63, 17);
            this.checkBoxSPN.TabIndex = 2;
            this.checkBoxSPN.Text = "SPN-16";
            this.checkBoxSPN.UseVisualStyleBackColor = true;
            this.checkBoxSPN.CheckedChanged += new System.EventHandler(this.checkBoxSPN_CheckedChanged);
            // 
            // checkBoxSHA
            // 
            this.checkBoxSHA.AutoSize = true;
            this.checkBoxSHA.Location = new System.Drawing.Point(164, 193);
            this.checkBoxSHA.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxSHA.Name = "checkBoxSHA";
            this.checkBoxSHA.Size = new System.Drawing.Size(69, 17);
            this.checkBoxSHA.TabIndex = 3;
            this.checkBoxSHA.Text = "SHA-256";
            this.checkBoxSHA.UseVisualStyleBackColor = true;
            this.checkBoxSHA.CheckedChanged += new System.EventHandler(this.checkBoxSHA_CheckedChanged);
            // 
            // labelCipher
            // 
            this.labelCipher.AutoSize = true;
            this.labelCipher.Location = new System.Drawing.Point(27, 250);
            this.labelCipher.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCipher.Name = "labelCipher";
            this.labelCipher.Size = new System.Drawing.Size(61, 13);
            this.labelCipher.TabIndex = 4;
            this.labelCipher.Text = "Cipher Text";
            // 
            // txtCipher
            // 
            this.txtCipher.BackColor = System.Drawing.Color.Honeydew;
            this.txtCipher.Location = new System.Drawing.Point(29, 266);
            this.txtCipher.Margin = new System.Windows.Forms.Padding(2);
            this.txtCipher.MinimumSize = new System.Drawing.Size(76, 82);
            this.txtCipher.Multiline = true;
            this.txtCipher.Name = "txtCipher";
            this.txtCipher.Size = new System.Drawing.Size(222, 82);
            this.txtCipher.TabIndex = 5;
            this.txtCipher.TextChanged += new System.EventHandler(this.txtCipher_TextChanged);
            // 
            // btn_Encrypt
            // 
            this.btn_Encrypt.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_Encrypt.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_Encrypt.Location = new System.Drawing.Point(423, 334);
            this.btn_Encrypt.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Encrypt.Name = "btn_Encrypt";
            this.btn_Encrypt.Size = new System.Drawing.Size(79, 32);
            this.btn_Encrypt.TabIndex = 6;
            this.btn_Encrypt.Text = "Sifreleme";
            this.btn_Encrypt.UseVisualStyleBackColor = false;
            this.btn_Encrypt.Click += new System.EventHandler(this.btn_Encrypt_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(653, 20);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Key";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtKey
            // 
            this.txtKey.BackColor = System.Drawing.Color.Honeydew;
            this.txtKey.Location = new System.Drawing.Point(655, 36);
            this.txtKey.Margin = new System.Windows.Forms.Padding(2);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(76, 20);
            this.txtKey.TabIndex = 8;
            this.txtKey.Text = "facakici";
            this.txtKey.TextChanged += new System.EventHandler(this.txtKey_TextChanged);
            // 
            // btn_Decrypt
            // 
            this.btn_Decrypt.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_Decrypt.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_Decrypt.Location = new System.Drawing.Point(532, 334);
            this.btn_Decrypt.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Decrypt.Name = "btn_Decrypt";
            this.btn_Decrypt.Size = new System.Drawing.Size(79, 32);
            this.btn_Decrypt.TabIndex = 9;
            this.btn_Decrypt.Text = "Cozumleme";
            this.btn_Decrypt.UseVisualStyleBackColor = false;
            this.btn_Decrypt.Click += new System.EventHandler(this.btn_Decrypt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(760, 377);
            this.Controls.Add(this.btn_Decrypt);
            this.Controls.Add(this.txtKey);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_Encrypt);
            this.Controls.Add(this.txtCipher);
            this.Controls.Add(this.labelCipher);
            this.Controls.Add(this.checkBoxSHA);
            this.Controls.Add(this.checkBoxSPN);
            this.Controls.Add(this.txtPlain);
            this.Controls.Add(this.labelPText);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(50, 100);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPText;
        private System.Windows.Forms.TextBox txtPlain;
        private System.Windows.Forms.CheckBox checkBoxSPN;
        private System.Windows.Forms.CheckBox checkBoxSHA;
        private System.Windows.Forms.Label labelCipher;
        private System.Windows.Forms.TextBox txtCipher;
        private System.Windows.Forms.Button btn_Encrypt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.Button btn_Decrypt;
    }
}

