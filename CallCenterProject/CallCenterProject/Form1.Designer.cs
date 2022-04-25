namespace CallCenterProject
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
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.LBRapor = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnRapor = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txtNotAra = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnAra = new System.Windows.Forms.Button();
            this.LBAramaSonucu = new System.Windows.Forms.ListBox();
            this.Temsilci = new System.Windows.Forms.TabPage();
            this.btnStartCall = new System.Windows.Forms.Button();
            this.LBListele_1 = new System.Windows.Forms.ListBox();
            this.btnEndCall_4 = new System.Windows.Forms.Button();
            this.btnEndCall_3 = new System.Windows.Forms.Button();
            this.btnEndCall_2 = new System.Windows.Forms.Button();
            this.btnEndCall_1 = new System.Windows.Forms.Button();
            this.lBNowCall = new System.Windows.Forms.ListBox();
            this.txtNot = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.LBBekleyen = new System.Windows.Forms.ListBox();
            this.Musteri = new System.Windows.Forms.TabPage();
            this.btnCall = new System.Windows.Forms.Button();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.RBBireysel = new System.Windows.Forms.RadioButton();
            this.RBTicari = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTelNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.LBListele = new System.Windows.Forms.ListBox();
            this.DTPStart = new System.Windows.Forms.DateTimePicker();
            this.Tarih = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage4.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.Temsilci.SuspendLayout();
            this.Musteri.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btnRapor);
            this.tabPage4.Controls.Add(this.label6);
            this.tabPage4.Controls.Add(this.LBRapor);
            this.tabPage4.Location = new System.Drawing.Point(4, 29);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(728, 668);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Rapor";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // LBRapor
            // 
            this.LBRapor.FormattingEnabled = true;
            this.LBRapor.ItemHeight = 20;
            this.LBRapor.Location = new System.Drawing.Point(22, 94);
            this.LBRapor.Name = "LBRapor";
            this.LBRapor.Size = new System.Drawing.Size(673, 544);
            this.LBRapor.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(179, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Gunluk Bazda Cagri Sayisi";
            // 
            // btnRapor
            // 
            this.btnRapor.Location = new System.Drawing.Point(325, 34);
            this.btnRapor.Name = "btnRapor";
            this.btnRapor.Size = new System.Drawing.Size(131, 29);
            this.btnRapor.TabIndex = 2;
            this.btnRapor.Text = "RaporOlustur";
            this.btnRapor.UseVisualStyleBackColor = true;
            this.btnRapor.Click += new System.EventHandler(this.btnRapor_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.LBAramaSonucu);
            this.tabPage3.Controls.Add(this.BtnAra);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.txtNotAra);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(728, 668);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Arama";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // txtNotAra
            // 
            this.txtNotAra.Location = new System.Drawing.Point(35, 72);
            this.txtNotAra.Name = "txtNotAra";
            this.txtNotAra.Size = new System.Drawing.Size(440, 27);
            this.txtNotAra.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Aranacak  Not:";
            // 
            // BtnAra
            // 
            this.BtnAra.Location = new System.Drawing.Point(519, 71);
            this.BtnAra.Name = "BtnAra";
            this.BtnAra.Size = new System.Drawing.Size(94, 29);
            this.BtnAra.TabIndex = 2;
            this.BtnAra.Text = "Ara";
            this.BtnAra.UseVisualStyleBackColor = true;
            this.BtnAra.Click += new System.EventHandler(this.BtnAra_Click);
            // 
            // LBAramaSonucu
            // 
            this.LBAramaSonucu.FormattingEnabled = true;
            this.LBAramaSonucu.ItemHeight = 20;
            this.LBAramaSonucu.Location = new System.Drawing.Point(35, 147);
            this.LBAramaSonucu.Name = "LBAramaSonucu";
            this.LBAramaSonucu.Size = new System.Drawing.Size(628, 484);
            this.LBAramaSonucu.TabIndex = 4;
            // 
            // Temsilci
            // 
            this.Temsilci.Controls.Add(this.LBBekleyen);
            this.Temsilci.Controls.Add(this.label4);
            this.Temsilci.Controls.Add(this.txtNot);
            this.Temsilci.Controls.Add(this.lBNowCall);
            this.Temsilci.Controls.Add(this.btnEndCall_1);
            this.Temsilci.Controls.Add(this.btnEndCall_2);
            this.Temsilci.Controls.Add(this.btnEndCall_3);
            this.Temsilci.Controls.Add(this.btnEndCall_4);
            this.Temsilci.Controls.Add(this.LBListele_1);
            this.Temsilci.Controls.Add(this.btnStartCall);
            this.Temsilci.Location = new System.Drawing.Point(4, 29);
            this.Temsilci.Name = "Temsilci";
            this.Temsilci.Padding = new System.Windows.Forms.Padding(3);
            this.Temsilci.Size = new System.Drawing.Size(728, 668);
            this.Temsilci.TabIndex = 1;
            this.Temsilci.Text = "Temsilci";
            this.Temsilci.UseVisualStyleBackColor = true;
            // 
            // btnStartCall
            // 
            this.btnStartCall.Location = new System.Drawing.Point(239, 140);
            this.btnStartCall.Name = "btnStartCall";
            this.btnStartCall.Size = new System.Drawing.Size(158, 29);
            this.btnStartCall.TabIndex = 3;
            this.btnStartCall.Text = "Cagriyi Baslat";
            this.btnStartCall.UseVisualStyleBackColor = true;
            this.btnStartCall.Click += new System.EventHandler(this.btnStartCall_Click);
            // 
            // LBListele_1
            // 
            this.LBListele_1.FormattingEnabled = true;
            this.LBListele_1.ItemHeight = 20;
            this.LBListele_1.Location = new System.Drawing.Point(19, 17);
            this.LBListele_1.Name = "LBListele_1";
            this.LBListele_1.Size = new System.Drawing.Size(650, 104);
            this.LBListele_1.TabIndex = 12;
            // 
            // btnEndCall_4
            // 
            this.btnEndCall_4.Location = new System.Drawing.Point(511, 381);
            this.btnEndCall_4.Name = "btnEndCall_4";
            this.btnEndCall_4.Size = new System.Drawing.Size(158, 29);
            this.btnEndCall_4.TabIndex = 13;
            this.btnEndCall_4.Text = "CagriyiSonlandir_4";
            this.btnEndCall_4.UseVisualStyleBackColor = true;
            this.btnEndCall_4.Click += new System.EventHandler(this.btnEndCall_4_Click);
            // 
            // btnEndCall_3
            // 
            this.btnEndCall_3.Location = new System.Drawing.Point(347, 381);
            this.btnEndCall_3.Name = "btnEndCall_3";
            this.btnEndCall_3.Size = new System.Drawing.Size(158, 29);
            this.btnEndCall_3.TabIndex = 14;
            this.btnEndCall_3.Text = "CagriyiSonlandir_3";
            this.btnEndCall_3.UseVisualStyleBackColor = true;
            this.btnEndCall_3.Click += new System.EventHandler(this.btnEndCall_3_Click);
            // 
            // btnEndCall_2
            // 
            this.btnEndCall_2.Location = new System.Drawing.Point(183, 381);
            this.btnEndCall_2.Name = "btnEndCall_2";
            this.btnEndCall_2.Size = new System.Drawing.Size(158, 29);
            this.btnEndCall_2.TabIndex = 15;
            this.btnEndCall_2.Text = "CagriyiSonlandir_2";
            this.btnEndCall_2.UseVisualStyleBackColor = true;
            this.btnEndCall_2.Click += new System.EventHandler(this.btnEndCall_2_Click);
            // 
            // btnEndCall_1
            // 
            this.btnEndCall_1.Location = new System.Drawing.Point(19, 381);
            this.btnEndCall_1.Name = "btnEndCall_1";
            this.btnEndCall_1.Size = new System.Drawing.Size(158, 29);
            this.btnEndCall_1.TabIndex = 16;
            this.btnEndCall_1.Text = "CagriyiSonlandir_1";
            this.btnEndCall_1.UseVisualStyleBackColor = true;
            this.btnEndCall_1.Click += new System.EventHandler(this.btnEndCall_1_Click);
            // 
            // lBNowCall
            // 
            this.lBNowCall.FormattingEnabled = true;
            this.lBNowCall.ItemHeight = 20;
            this.lBNowCall.Location = new System.Drawing.Point(19, 185);
            this.lBNowCall.Name = "lBNowCall";
            this.lBNowCall.Size = new System.Drawing.Size(650, 104);
            this.lBNowCall.TabIndex = 17;
            // 
            // txtNot
            // 
            this.txtNot.Location = new System.Drawing.Point(84, 307);
            this.txtNot.Multiline = true;
            this.txtNot.Name = "txtNot";
            this.txtNot.Size = new System.Drawing.Size(585, 47);
            this.txtNot.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 310);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "Not";
            // 
            // LBBekleyen
            // 
            this.LBBekleyen.FormattingEnabled = true;
            this.LBBekleyen.ItemHeight = 20;
            this.LBBekleyen.Location = new System.Drawing.Point(19, 435);
            this.LBBekleyen.Name = "LBBekleyen";
            this.LBBekleyen.Size = new System.Drawing.Size(681, 204);
            this.LBBekleyen.TabIndex = 20;
            // 
            // Musteri
            // 
            this.Musteri.Controls.Add(this.Tarih);
            this.Musteri.Controls.Add(this.DTPStart);
            this.Musteri.Controls.Add(this.LBListele);
            this.Musteri.Controls.Add(this.label3);
            this.Musteri.Controls.Add(this.txtTelNo);
            this.Musteri.Controls.Add(this.txtLastName);
            this.Musteri.Controls.Add(this.txtFirstName);
            this.Musteri.Controls.Add(this.label2);
            this.Musteri.Controls.Add(this.label1);
            this.Musteri.Controls.Add(this.RBTicari);
            this.Musteri.Controls.Add(this.RBBireysel);
            this.Musteri.Controls.Add(this.btnCall);
            this.Musteri.Location = new System.Drawing.Point(4, 29);
            this.Musteri.Name = "Musteri";
            this.Musteri.Padding = new System.Windows.Forms.Padding(3);
            this.Musteri.Size = new System.Drawing.Size(728, 668);
            this.Musteri.TabIndex = 0;
            this.Musteri.Text = "Musteri";
            this.Musteri.UseVisualStyleBackColor = true;
            // 
            // btnCall
            // 
            this.btnCall.Location = new System.Drawing.Point(203, 264);
            this.btnCall.Name = "btnCall";
            this.btnCall.Size = new System.Drawing.Size(94, 29);
            this.btnCall.TabIndex = 0;
            this.btnCall.Text = "Call";
            this.btnCall.UseVisualStyleBackColor = true;
            this.btnCall.Click += new System.EventHandler(this.btnCall_Click);
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(157, 24);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(222, 27);
            this.txtFirstName.TabIndex = 2;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(157, 75);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(222, 27);
            this.txtLastName.TabIndex = 3;
            // 
            // RBBireysel
            // 
            this.RBBireysel.AutoSize = true;
            this.RBBireysel.Location = new System.Drawing.Point(157, 220);
            this.RBBireysel.Name = "RBBireysel";
            this.RBBireysel.Size = new System.Drawing.Size(81, 24);
            this.RBBireysel.TabIndex = 4;
            this.RBBireysel.Text = "Bireysel";
            this.RBBireysel.UseVisualStyleBackColor = true;
            // 
            // RBTicari
            // 
            this.RBTicari.AutoSize = true;
            this.RBTicari.Location = new System.Drawing.Point(289, 220);
            this.RBTicari.Name = "RBTicari";
            this.RBTicari.Size = new System.Drawing.Size(66, 24);
            this.RBTicari.TabIndex = 5;
            this.RBTicari.Text = "Ticari";
            this.RBTicari.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Isim";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "SoyIsim";
            // 
            // txtTelNo
            // 
            this.txtTelNo.Location = new System.Drawing.Point(157, 124);
            this.txtTelNo.Name = "txtTelNo";
            this.txtTelNo.Size = new System.Drawing.Size(222, 27);
            this.txtTelNo.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "TelNO";
            // 
            // LBListele
            // 
            this.LBListele.FormattingEnabled = true;
            this.LBListele.ItemHeight = 20;
            this.LBListele.Location = new System.Drawing.Point(22, 326);
            this.LBListele.Name = "LBListele";
            this.LBListele.Size = new System.Drawing.Size(681, 324);
            this.LBListele.TabIndex = 10;
            // 
            // DTPStart
            // 
            this.DTPStart.Location = new System.Drawing.Point(157, 175);
            this.DTPStart.Name = "DTPStart";
            this.DTPStart.Size = new System.Drawing.Size(250, 27);
            this.DTPStart.TabIndex = 14;
            // 
            // Tarih
            // 
            this.Tarih.AutoSize = true;
            this.Tarih.Location = new System.Drawing.Point(86, 175);
            this.Tarih.Name = "Tarih";
            this.Tarih.Size = new System.Drawing.Size(40, 20);
            this.Tarih.TabIndex = 15;
            this.Tarih.Text = "Tarih";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Musteri);
            this.tabControl1.Controls.Add(this.Temsilci);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(1, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(736, 701);
            this.tabControl1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 696);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.Temsilci.ResumeLayout(false);
            this.Temsilci.PerformLayout();
            this.Musteri.ResumeLayout(false);
            this.Musteri.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage4;
        private Button btnRapor;
        private Label label6;
        private ListBox LBRapor;
        private TabPage tabPage3;
        private ListBox LBAramaSonucu;
        private Button BtnAra;
        private Label label5;
        private TextBox txtNotAra;
        private TabPage Temsilci;
        private ListBox LBBekleyen;
        private Label label4;
        private TextBox txtNot;
        private ListBox lBNowCall;
        private Button btnEndCall_1;
        private Button btnEndCall_2;
        private Button btnEndCall_3;
        private Button btnEndCall_4;
        private ListBox LBListele_1;
        private Button btnStartCall;
        private TabPage Musteri;
        private Label Tarih;
        private DateTimePicker DTPStart;
        private ListBox LBListele;
        private Label label3;
        private TextBox txtTelNo;
        private TextBox txtLastName;
        private TextBox txtFirstName;
        private Label label2;
        private Label label1;
        private RadioButton RBTicari;
        private RadioButton RBBireysel;
        private Button btnCall;
        private TabControl tabControl1;
    }
}