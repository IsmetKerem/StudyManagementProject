namespace StudyManagementProject
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnetutadd = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.msksaat = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbogretmen = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.msktarih = new System.Windows.Forms.MaskedTextBox();
            this.cmbders = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtetutıd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtogrenciid = new System.Windows.Forms.TextBox();
            this.btnetutver = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtders = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.msktelefon = new System.Windows.Forms.MaskedTextBox();
            this.btnogrenciekle = new System.Windows.Forms.Button();
            this.txtmail = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtsinif = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtsoyad = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtad = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnfotograf = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.cmbbrans = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtogretmensoyad = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtogretmenad = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnetutadd);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.msksaat);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmbogretmen);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.msktarih);
            this.groupBox1.Controls.Add(this.cmbders);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(403, 248);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnetutadd
            // 
            this.btnetutadd.Location = new System.Drawing.Point(126, 192);
            this.btnetutadd.Name = "btnetutadd";
            this.btnetutadd.Size = new System.Drawing.Size(145, 37);
            this.btnetutadd.TabIndex = 8;
            this.btnetutadd.Text = "Etüt Oluştur";
            this.btnetutadd.UseVisualStyleBackColor = true;
            this.btnetutadd.Click += new System.EventHandler(this.btnetutadd_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(47, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Saat:";
            // 
            // msksaat
            // 
            this.msksaat.Location = new System.Drawing.Point(98, 160);
            this.msksaat.Mask = "00:00";
            this.msksaat.Name = "msksaat";
            this.msksaat.Size = new System.Drawing.Size(213, 26);
            this.msksaat.TabIndex = 6;
            this.msksaat.ValidatingType = typeof(System.DateTime);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(39, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tarih:";
            // 
            // cmbogretmen
            // 
            this.cmbogretmen.FormattingEnabled = true;
            this.cmbogretmen.Location = new System.Drawing.Point(97, 76);
            this.cmbogretmen.Name = "cmbogretmen";
            this.cmbogretmen.Size = new System.Drawing.Size(213, 26);
            this.cmbogretmen.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(6, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Öğretmen:";
            // 
            // msktarih
            // 
            this.msktarih.Location = new System.Drawing.Point(98, 119);
            this.msktarih.Mask = "00/00/0000";
            this.msktarih.Name = "msktarih";
            this.msktarih.Size = new System.Drawing.Size(213, 26);
            this.msktarih.TabIndex = 2;
            this.msktarih.ValidatingType = typeof(System.DateTime);
            // 
            // cmbders
            // 
            this.cmbders.FormattingEnabled = true;
            this.cmbders.Location = new System.Drawing.Point(98, 33);
            this.cmbders.Name = "cmbders";
            this.cmbders.Size = new System.Drawing.Size(213, 26);
            this.cmbders.TabIndex = 1;
            this.cmbders.SelectedIndexChanged += new System.EventHandler(this.cmbders_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(45, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ders:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtetutıd);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtogrenciid);
            this.groupBox2.Controls.Add(this.btnetutver);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(421, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(451, 156);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // txtetutıd
            // 
            this.txtetutıd.Location = new System.Drawing.Point(137, 33);
            this.txtetutıd.Name = "txtetutıd";
            this.txtetutıd.Size = new System.Drawing.Size(147, 26);
            this.txtetutıd.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(63, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 18);
            this.label5.TabIndex = 14;
            this.label5.Text = "Etüt İd:";
            // 
            // txtogrenciid
            // 
            this.txtogrenciid.Location = new System.Drawing.Point(139, 71);
            this.txtogrenciid.Name = "txtogrenciid";
            this.txtogrenciid.Size = new System.Drawing.Size(147, 26);
            this.txtogrenciid.TabIndex = 13;
            // 
            // btnetutver
            // 
            this.btnetutver.Location = new System.Drawing.Point(139, 109);
            this.btnetutver.Name = "btnetutver";
            this.btnetutver.Size = new System.Drawing.Size(145, 37);
            this.btnetutver.TabIndex = 9;
            this.btnetutver.Text = "Etüt Ver";
            this.btnetutver.UseVisualStyleBackColor = true;
            this.btnetutver.Click += new System.EventHandler(this.btnetutver_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(65, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 18);
            this.label6.TabIndex = 10;
            this.label6.Text = "Öğrenci:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(12, 266);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1132, 255);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1126, 230);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Controls.Add(this.txtders);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Location = new System.Drawing.Point(421, 174);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(451, 86);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(282, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 37);
            this.button1.TabIndex = 27;
            this.button1.Text = "Ders Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtders
            // 
            this.txtders.Location = new System.Drawing.Point(94, 36);
            this.txtders.Name = "txtders";
            this.txtders.Size = new System.Drawing.Size(147, 26);
            this.txtders.TabIndex = 28;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(20, 39);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 18);
            this.label10.TabIndex = 27;
            this.label10.Text = "Ders Adı:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.msktelefon);
            this.groupBox5.Controls.Add(this.btnogrenciekle);
            this.groupBox5.Controls.Add(this.txtmail);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.txtsinif);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.txtsoyad);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.txtad);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Location = new System.Drawing.Point(878, 18);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(266, 233);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            // 
            // msktelefon
            // 
            this.msktelefon.Location = new System.Drawing.Point(84, 113);
            this.msktelefon.Mask = "(999) 000-0000";
            this.msktelefon.Name = "msktelefon";
            this.msktelefon.Size = new System.Drawing.Size(147, 26);
            this.msktelefon.TabIndex = 26;
            // 
            // btnogrenciekle
            // 
            this.btnogrenciekle.Location = new System.Drawing.Point(84, 186);
            this.btnogrenciekle.Name = "btnogrenciekle";
            this.btnogrenciekle.Size = new System.Drawing.Size(145, 37);
            this.btnogrenciekle.TabIndex = 16;
            this.btnogrenciekle.Text = "Öğrenci Ekle";
            this.btnogrenciekle.UseVisualStyleBackColor = true;
            this.btnogrenciekle.Click += new System.EventHandler(this.btnogrenciekle_Click);
            // 
            // txtmail
            // 
            this.txtmail.Location = new System.Drawing.Point(84, 146);
            this.txtmail.Name = "txtmail";
            this.txtmail.Size = new System.Drawing.Size(147, 26);
            this.txtmail.TabIndex = 25;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(10, 149);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 18);
            this.label12.TabIndex = 24;
            this.label12.Text = "Mail:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(10, 114);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 18);
            this.label11.TabIndex = 22;
            this.label11.Text = "Telefon:";
            // 
            // txtsinif
            // 
            this.txtsinif.Location = new System.Drawing.Point(84, 82);
            this.txtsinif.Name = "txtsinif";
            this.txtsinif.Size = new System.Drawing.Size(147, 26);
            this.txtsinif.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(10, 85);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 18);
            this.label9.TabIndex = 20;
            this.label9.Text = "Sınıf:";
            // 
            // txtsoyad
            // 
            this.txtsoyad.Location = new System.Drawing.Point(84, 50);
            this.txtsoyad.Name = "txtsoyad";
            this.txtsoyad.Size = new System.Drawing.Size(147, 26);
            this.txtsoyad.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(10, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 18);
            this.label8.TabIndex = 18;
            this.label8.Text = "Soyad:";
            // 
            // txtad
            // 
            this.txtad.Location = new System.Drawing.Point(84, 18);
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(147, 26);
            this.txtad.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(10, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 18);
            this.label7.TabIndex = 16;
            this.label7.Text = "Ad:";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnfotograf);
            this.groupBox6.Controls.Add(this.pictureBox1);
            this.groupBox6.Location = new System.Drawing.Point(1161, 21);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(266, 230);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            // 
            // btnfotograf
            // 
            this.btnfotograf.Location = new System.Drawing.Point(72, 189);
            this.btnfotograf.Name = "btnfotograf";
            this.btnfotograf.Size = new System.Drawing.Size(146, 28);
            this.btnfotograf.TabIndex = 1;
            this.btnfotograf.Text = "Fotoğraf Yükle";
            this.btnfotograf.UseVisualStyleBackColor = true;
            this.btnfotograf.Click += new System.EventHandler(this.btnfotograf_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(10, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 162);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.button2);
            this.groupBox7.Controls.Add(this.cmbbrans);
            this.groupBox7.Controls.Add(this.label13);
            this.groupBox7.Controls.Add(this.txtogretmensoyad);
            this.groupBox7.Controls.Add(this.label14);
            this.groupBox7.Controls.Add(this.txtogretmenad);
            this.groupBox7.Controls.Add(this.label15);
            this.groupBox7.Location = new System.Drawing.Point(1161, 278);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(266, 230);
            this.groupBox7.TabIndex = 6;
            this.groupBox7.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(95, 132);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(145, 37);
            this.button2.TabIndex = 28;
            this.button2.Text = "Öğretmen Ekle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cmbbrans
            // 
            this.cmbbrans.FormattingEnabled = true;
            this.cmbbrans.Location = new System.Drawing.Point(93, 89);
            this.cmbbrans.Name = "cmbbrans";
            this.cmbbrans.Size = new System.Drawing.Size(147, 26);
            this.cmbbrans.TabIndex = 27;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(20, 92);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(54, 18);
            this.label13.TabIndex = 26;
            this.label13.Text = "Branş:";
            // 
            // txtogretmensoyad
            // 
            this.txtogretmensoyad.Location = new System.Drawing.Point(93, 57);
            this.txtogretmensoyad.Name = "txtogretmensoyad";
            this.txtogretmensoyad.Size = new System.Drawing.Size(147, 26);
            this.txtogretmensoyad.TabIndex = 25;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(18, 60);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(56, 18);
            this.label14.TabIndex = 24;
            this.label14.Text = "Soyad:";
            // 
            // txtogretmenad
            // 
            this.txtogretmenad.Location = new System.Drawing.Point(93, 25);
            this.txtogretmenad.Name = "txtogretmenad";
            this.txtogretmenad.Size = new System.Drawing.Size(147, 26);
            this.txtogretmenad.TabIndex = 23;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(41, 28);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(33, 18);
            this.label15.TabIndex = 22;
            this.label15.Text = "Ad:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(59)))), ((int)(((byte)(110)))));
            this.ClientSize = new System.Drawing.Size(1439, 520);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Etüt Yönetim";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox msksaat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbogretmen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox msktarih;
        private System.Windows.Forms.ComboBox cmbders;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnetutadd;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnetutver;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtogrenciid;
        private System.Windows.Forms.TextBox txtetutıd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TextBox txtsoyad;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnogrenciekle;
        private System.Windows.Forms.TextBox txtmail;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtsinif;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox msktelefon;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtders;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnfotograf;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cmbbrans;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtogretmensoyad;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtogretmenad;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

