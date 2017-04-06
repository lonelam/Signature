namespace Signature
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
            this.importbutton = new System.Windows.Forms.Button();
            this.certificate = new System.Windows.Forms.RichTextBox();
            this.nametxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pubtxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.msgtxt = new System.Windows.Forms.TextBox();
            this.Signbut = new System.Windows.Forms.Button();
            this.btn_import_CA = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.sigtxt = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.pswtxt = new System.Windows.Forms.TextBox();
            this.Issuertxt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.towhomtxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.emailtxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.algtxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // importbutton
            // 
            this.importbutton.Location = new System.Drawing.Point(228, 11);
            this.importbutton.Name = "importbutton";
            this.importbutton.Size = new System.Drawing.Size(89, 23);
            this.importbutton.TabIndex = 0;
            this.importbutton.Text = "Import...";
            this.importbutton.UseVisualStyleBackColor = true;
            this.importbutton.Click += new System.EventHandler(this.importbutton_Click);
            // 
            // certificate
            // 
            this.certificate.Location = new System.Drawing.Point(12, 12);
            this.certificate.Name = "certificate";
            this.certificate.Size = new System.Drawing.Size(210, 433);
            this.certificate.TabIndex = 1;
            this.certificate.Text = "";
            // 
            // nametxt
            // 
            this.nametxt.Location = new System.Drawing.Point(323, 37);
            this.nametxt.Multiline = true;
            this.nametxt.Name = "nametxt";
            this.nametxt.Size = new System.Drawing.Size(307, 106);
            this.nametxt.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(320, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Information";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(228, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Generate<";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(320, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "publickey";
            // 
            // pubtxt
            // 
            this.pubtxt.Location = new System.Drawing.Point(323, 164);
            this.pubtxt.Multiline = true;
            this.pubtxt.Name = "pubtxt";
            this.pubtxt.Size = new System.Drawing.Size(307, 106);
            this.pubtxt.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(320, 273);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Message";
            // 
            // msgtxt
            // 
            this.msgtxt.Location = new System.Drawing.Point(323, 291);
            this.msgtxt.Multiline = true;
            this.msgtxt.Name = "msgtxt";
            this.msgtxt.Size = new System.Drawing.Size(307, 29);
            this.msgtxt.TabIndex = 8;
            // 
            // Signbut
            // 
            this.Signbut.Location = new System.Drawing.Point(228, 69);
            this.Signbut.Name = "Signbut";
            this.Signbut.Size = new System.Drawing.Size(89, 23);
            this.Signbut.TabIndex = 9;
            this.Signbut.Text = "Sign";
            this.Signbut.UseVisualStyleBackColor = true;
            this.Signbut.Click += new System.EventHandler(this.Signbut_Click);
            // 
            // btn_import_CA
            // 
            this.btn_import_CA.Location = new System.Drawing.Point(228, 98);
            this.btn_import_CA.Name = "btn_import_CA";
            this.btn_import_CA.Size = new System.Drawing.Size(89, 23);
            this.btn_import_CA.TabIndex = 10;
            this.btn_import_CA.Text = "CA...";
            this.btn_import_CA.UseVisualStyleBackColor = true;
            this.btn_import_CA.Click += new System.EventHandler(this.btn_import_CA_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(228, 127);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Verify";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(320, 323);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Signature";
            // 
            // sigtxt
            // 
            this.sigtxt.Location = new System.Drawing.Point(323, 341);
            this.sigtxt.Name = "sigtxt";
            this.sigtxt.Size = new System.Drawing.Size(307, 25);
            this.sigtxt.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.pswtxt);
            this.groupBox1.Controls.Add(this.Issuertxt);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.towhomtxt);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.emailtxt);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.algtxt);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBox1.Location = new System.Drawing.Point(661, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(172, 433);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "证书申请表";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 205);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 15);
            this.label9.TabIndex = 22;
            this.label9.Text = "设置密码";
            // 
            // pswtxt
            // 
            this.pswtxt.Location = new System.Drawing.Point(6, 223);
            this.pswtxt.Name = "pswtxt";
            this.pswtxt.Size = new System.Drawing.Size(160, 25);
            this.pswtxt.TabIndex = 21;
            this.pswtxt.Text = "123456";
            // 
            // Issuertxt
            // 
            this.Issuertxt.Location = new System.Drawing.Point(6, 177);
            this.Issuertxt.Name = "Issuertxt";
            this.Issuertxt.Size = new System.Drawing.Size(160, 25);
            this.Issuertxt.TabIndex = 20;
            this.Issuertxt.Text = "self";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 159);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 15);
            this.label8.TabIndex = 19;
            this.label8.Text = "颁发者";
            // 
            // towhomtxt
            // 
            this.towhomtxt.Location = new System.Drawing.Point(6, 131);
            this.towhomtxt.Name = "towhomtxt";
            this.towhomtxt.Size = new System.Drawing.Size(160, 25);
            this.towhomtxt.TabIndex = 18;
            this.towhomtxt.Text = "digested.site";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 15);
            this.label6.TabIndex = 15;
            this.label6.Text = "颁发给";
            // 
            // emailtxt
            // 
            this.emailtxt.Location = new System.Drawing.Point(6, 84);
            this.emailtxt.Name = "emailtxt";
            this.emailtxt.Size = new System.Drawing.Size(160, 25);
            this.emailtxt.TabIndex = 17;
            this.emailtxt.Text = "laizenan@gmail.com";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 15);
            this.label7.TabIndex = 16;
            this.label7.Text = "邮箱";
            // 
            // algtxt
            // 
            this.algtxt.Location = new System.Drawing.Point(6, 39);
            this.algtxt.Name = "algtxt";
            this.algtxt.Size = new System.Drawing.Size(160, 25);
            this.algtxt.TabIndex = 1;
            this.algtxt.Text = "SHA1WithRSA";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "加密算法";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 457);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.sigtxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_import_CA);
            this.Controls.Add(this.Signbut);
            this.Controls.Add(this.msgtxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pubtxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nametxt);
            this.Controls.Add(this.certificate);
            this.Controls.Add(this.importbutton);
            this.Name = "Form1";
            this.Text = "证书操作";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button importbutton;
        private System.Windows.Forms.RichTextBox certificate;
        private System.Windows.Forms.TextBox nametxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox pubtxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox msgtxt;
        private System.Windows.Forms.Button Signbut;
        private System.Windows.Forms.Button btn_import_CA;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox sigtxt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox algtxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox emailtxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox towhomtxt;
        private System.Windows.Forms.TextBox Issuertxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox pswtxt;
    }
}

