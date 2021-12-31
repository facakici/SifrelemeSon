namespace SPN_16_Sifreleme
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.btn_Decrypt = new System.Windows.Forms.Button();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Encrypt = new System.Windows.Forms.Button();
            this.txtCipher = new System.Windows.Forms.TextBox();
            this.labelCipher = new System.Windows.Forms.Label();
            this.checkBoxSHA = new System.Windows.Forms.CheckBox();
            this.checkBoxSPN = new System.Windows.Forms.CheckBox();
            this.txtPlain = new System.Windows.Forms.TextBox();
            this.labelPText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Decrypt
            // 
            this.btn_Decrypt.Location = new System.Drawing.Point(533, 334);
            this.btn_Decrypt.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Decrypt.Name = "btn_Decrypt";
            this.btn_Decrypt.Size = new System.Drawing.Size(79, 32);
            this.btn_Decrypt.TabIndex = 19;
            this.btn_Decrypt.Text = "Cozumleme";
            this.btn_Decrypt.UseVisualStyleBackColor = true;
            this.btn_Decrypt.Click += new System.EventHandler(this.btn_Decrypt_Click);
            // 
            // txtKey
            // 
            this.txtKey.Location = new System.Drawing.Point(658, 46);
            this.txtKey.Margin = new System.Windows.Forms.Padding(2);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(76, 20);
            this.txtKey.TabIndex = 18;
            this.txtKey.Text = "facakici";
            this.txtKey.TextChanged += new System.EventHandler(this.txtKey_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(656, 30);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Key";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btn_Encrypt
            // 
            this.btn_Encrypt.Location = new System.Drawing.Point(428, 334);
            this.btn_Encrypt.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Encrypt.Name = "btn_Encrypt";
            this.btn_Encrypt.Size = new System.Drawing.Size(79, 32);
            this.btn_Encrypt.TabIndex = 16;
            this.btn_Encrypt.Text = "Sifreleme";
            this.btn_Encrypt.UseVisualStyleBackColor = true;
            this.btn_Encrypt.Click += new System.EventHandler(this.btn_Encrypt_Click);
            // 
            // txtCipher
            // 
            this.txtCipher.Location = new System.Drawing.Point(30, 246);
            this.txtCipher.Margin = new System.Windows.Forms.Padding(2);
            this.txtCipher.MinimumSize = new System.Drawing.Size(76, 82);
            this.txtCipher.Multiline = true;
            this.txtCipher.Name = "txtCipher";
            this.txtCipher.Size = new System.Drawing.Size(222, 82);
            this.txtCipher.TabIndex = 15;
            // 
            // labelCipher
            // 
            this.labelCipher.AutoSize = true;
            this.labelCipher.Location = new System.Drawing.Point(28, 230);
            this.labelCipher.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCipher.Name = "labelCipher";
            this.labelCipher.Size = new System.Drawing.Size(61, 13);
            this.labelCipher.TabIndex = 14;
            this.labelCipher.Text = "Cipher Text";
            // 
            // checkBoxSHA
            // 
            this.checkBoxSHA.AutoSize = true;
            this.checkBoxSHA.Location = new System.Drawing.Point(148, 185);
            this.checkBoxSHA.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxSHA.Name = "checkBoxSHA";
            this.checkBoxSHA.Size = new System.Drawing.Size(69, 17);
            this.checkBoxSHA.TabIndex = 13;
            this.checkBoxSHA.Text = "SHA-256";
            this.checkBoxSHA.UseVisualStyleBackColor = true;
            this.checkBoxSHA.CheckedChanged += new System.EventHandler(this.checkBoxSHA_CheckedChanged);
            // 
            // checkBoxSPN
            // 
            this.checkBoxSPN.AutoSize = true;
            this.checkBoxSPN.Location = new System.Drawing.Point(45, 185);
            this.checkBoxSPN.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxSPN.Name = "checkBoxSPN";
            this.checkBoxSPN.Size = new System.Drawing.Size(63, 17);
            this.checkBoxSPN.TabIndex = 12;
            this.checkBoxSPN.Text = "SPN-16";
            this.checkBoxSPN.UseVisualStyleBackColor = true;
            this.checkBoxSPN.CheckedChanged += new System.EventHandler(this.checkBoxSPN_CheckedChanged);
            // 
            // txtPlain
            // 
            this.txtPlain.Location = new System.Drawing.Point(30, 61);
            this.txtPlain.Margin = new System.Windows.Forms.Padding(2);
            this.txtPlain.MinimumSize = new System.Drawing.Size(76, 82);
            this.txtPlain.Multiline = true;
            this.txtPlain.Name = "txtPlain";
            this.txtPlain.Size = new System.Drawing.Size(222, 82);
            this.txtPlain.TabIndex = 11;
            // 
            // labelPText
            // 
            this.labelPText.AutoSize = true;
            this.labelPText.Location = new System.Drawing.Point(28, 45);
            this.labelPText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPText.Name = "labelPText";
            this.labelPText.Size = new System.Drawing.Size(54, 13);
            this.labelPText.TabIndex = 10;
            this.labelPText.Text = "Plain Text";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
            this.Location = new System.Drawing.Point(680, 100);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Decrypt;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Encrypt;
        private System.Windows.Forms.TextBox txtCipher;
        private System.Windows.Forms.Label labelCipher;
        private System.Windows.Forms.CheckBox checkBoxSHA;
        private System.Windows.Forms.CheckBox checkBoxSPN;
        private System.Windows.Forms.TextBox txtPlain;
        private System.Windows.Forms.Label labelPText;
    }
}