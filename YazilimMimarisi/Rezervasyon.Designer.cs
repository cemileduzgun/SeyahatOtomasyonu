
namespace YazilimMimarisi
{
    partial class Rezervasyon
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
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.ulasimTuru = new Guna.UI2.WinForms.Guna2ComboBox();
            this.gidisTarihi = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.donusTarihi = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.girisTarihi = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.cikisTarihi = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.tbBulunduguYer = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbGidecegiYer = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel6 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel7 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel8 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.konaklamaTuru = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel9 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel10 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel11 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.SuspendLayout();
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(337, 31);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(179, 26);
            this.guna2HtmlLabel1.TabIndex = 0;
            this.guna2HtmlLabel1.Text = "Rezervasyon Yap";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(202, 97);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(55, 21);
            this.guna2HtmlLabel2.TabIndex = 1;
            this.guna2HtmlLabel2.Text = "Ulaşım";
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(637, 97);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(89, 21);
            this.guna2HtmlLabel3.TabIndex = 2;
            this.guna2HtmlLabel3.Text = "Konaklama";
            // 
            // ulasimTuru
            // 
            this.ulasimTuru.BackColor = System.Drawing.Color.Transparent;
            this.ulasimTuru.BorderRadius = 10;
            this.ulasimTuru.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ulasimTuru.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ulasimTuru.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ulasimTuru.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ulasimTuru.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ulasimTuru.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.ulasimTuru.ItemHeight = 30;
            this.ulasimTuru.Items.AddRange(new object[] {
            "Uçak",
            "Otobüs"});
            this.ulasimTuru.Location = new System.Drawing.Point(167, 147);
            this.ulasimTuru.Name = "ulasimTuru";
            this.ulasimTuru.Size = new System.Drawing.Size(179, 36);
            this.ulasimTuru.TabIndex = 3;
            // 
            // gidisTarihi
            // 
            this.gidisTarihi.BorderRadius = 10;
            this.gidisTarihi.Checked = true;
            this.gidisTarihi.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.gidisTarihi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gidisTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.gidisTarihi.Location = new System.Drawing.Point(167, 202);
            this.gidisTarihi.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.gidisTarihi.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.gidisTarihi.Name = "gidisTarihi";
            this.gidisTarihi.Size = new System.Drawing.Size(179, 34);
            this.gidisTarihi.TabIndex = 5;
            this.gidisTarihi.Value = new System.DateTime(2022, 5, 20, 12, 56, 57, 61);
            // 
            // donusTarihi
            // 
            this.donusTarihi.BorderRadius = 10;
            this.donusTarihi.Checked = true;
            this.donusTarihi.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.donusTarihi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.donusTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.donusTarihi.Location = new System.Drawing.Point(167, 257);
            this.donusTarihi.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.donusTarihi.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.donusTarihi.Name = "donusTarihi";
            this.donusTarihi.Size = new System.Drawing.Size(179, 34);
            this.donusTarihi.TabIndex = 6;
            this.donusTarihi.Value = new System.DateTime(2022, 5, 20, 12, 56, 57, 61);
            // 
            // girisTarihi
            // 
            this.girisTarihi.BorderRadius = 10;
            this.girisTarihi.Checked = true;
            this.girisTarihi.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.girisTarihi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.girisTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.girisTarihi.Location = new System.Drawing.Point(611, 211);
            this.girisTarihi.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.girisTarihi.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.girisTarihi.Name = "girisTarihi";
            this.girisTarihi.Size = new System.Drawing.Size(179, 34);
            this.girisTarihi.TabIndex = 7;
            this.girisTarihi.Value = new System.DateTime(2022, 5, 20, 12, 56, 57, 61);
            // 
            // cikisTarihi
            // 
            this.cikisTarihi.BorderRadius = 10;
            this.cikisTarihi.Checked = true;
            this.cikisTarihi.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.cikisTarihi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cikisTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.cikisTarihi.Location = new System.Drawing.Point(611, 275);
            this.cikisTarihi.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.cikisTarihi.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.cikisTarihi.Name = "cikisTarihi";
            this.cikisTarihi.Size = new System.Drawing.Size(179, 34);
            this.cikisTarihi.TabIndex = 8;
            this.cikisTarihi.Value = new System.DateTime(2022, 5, 20, 12, 56, 57, 61);
            // 
            // tbBulunduguYer
            // 
            this.tbBulunduguYer.BorderRadius = 10;
            this.tbBulunduguYer.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbBulunduguYer.DefaultText = "";
            this.tbBulunduguYer.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbBulunduguYer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbBulunduguYer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbBulunduguYer.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbBulunduguYer.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbBulunduguYer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbBulunduguYer.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbBulunduguYer.Location = new System.Drawing.Point(167, 310);
            this.tbBulunduguYer.Name = "tbBulunduguYer";
            this.tbBulunduguYer.PasswordChar = '\0';
            this.tbBulunduguYer.PlaceholderText = "";
            this.tbBulunduguYer.SelectedText = "";
            this.tbBulunduguYer.Size = new System.Drawing.Size(179, 36);
            this.tbBulunduguYer.TabIndex = 9;
            // 
            // tbGidecegiYer
            // 
            this.tbGidecegiYer.BorderRadius = 10;
            this.tbGidecegiYer.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbGidecegiYer.DefaultText = "";
            this.tbGidecegiYer.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbGidecegiYer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbGidecegiYer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbGidecegiYer.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbGidecegiYer.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbGidecegiYer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbGidecegiYer.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbGidecegiYer.Location = new System.Drawing.Point(167, 366);
            this.tbGidecegiYer.Name = "tbGidecegiYer";
            this.tbGidecegiYer.PasswordChar = '\0';
            this.tbGidecegiYer.PlaceholderText = "";
            this.tbGidecegiYer.SelectedText = "";
            this.tbGidecegiYer.Size = new System.Drawing.Size(179, 36);
            this.tbGidecegiYer.TabIndex = 10;
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(59, 156);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(99, 15);
            this.guna2HtmlLabel4.TabIndex = 13;
            this.guna2HtmlLabel4.Text = "Ulaşım Türü Seçiniz:";
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(59, 211);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(58, 15);
            this.guna2HtmlLabel5.TabIndex = 14;
            this.guna2HtmlLabel5.Text = "Gidiş Tarihi:";
            // 
            // guna2HtmlLabel6
            // 
            this.guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel6.Location = new System.Drawing.Point(59, 266);
            this.guna2HtmlLabel6.Name = "guna2HtmlLabel6";
            this.guna2HtmlLabel6.Size = new System.Drawing.Size(66, 15);
            this.guna2HtmlLabel6.TabIndex = 15;
            this.guna2HtmlLabel6.Text = "Dönüş Tarihi:";
            // 
            // guna2HtmlLabel7
            // 
            this.guna2HtmlLabel7.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel7.Location = new System.Drawing.Point(59, 321);
            this.guna2HtmlLabel7.Name = "guna2HtmlLabel7";
            this.guna2HtmlLabel7.Size = new System.Drawing.Size(76, 15);
            this.guna2HtmlLabel7.TabIndex = 16;
            this.guna2HtmlLabel7.Text = "Bulunduğu Yer:";
            // 
            // guna2HtmlLabel8
            // 
            this.guna2HtmlLabel8.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel8.Location = new System.Drawing.Point(59, 376);
            this.guna2HtmlLabel8.Name = "guna2HtmlLabel8";
            this.guna2HtmlLabel8.Size = new System.Drawing.Size(65, 15);
            this.guna2HtmlLabel8.TabIndex = 17;
            this.guna2HtmlLabel8.Text = "Gideceği yer:";
            // 
            // konaklamaTuru
            // 
            this.konaklamaTuru.BackColor = System.Drawing.Color.Transparent;
            this.konaklamaTuru.BorderRadius = 10;
            this.konaklamaTuru.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.konaklamaTuru.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.konaklamaTuru.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.konaklamaTuru.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.konaklamaTuru.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.konaklamaTuru.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.konaklamaTuru.ItemHeight = 30;
            this.konaklamaTuru.Items.AddRange(new object[] {
            "Otel",
            "Çadır"});
            this.konaklamaTuru.Location = new System.Drawing.Point(611, 147);
            this.konaklamaTuru.Name = "konaklamaTuru";
            this.konaklamaTuru.Size = new System.Drawing.Size(179, 36);
            this.konaklamaTuru.TabIndex = 18;
            // 
            // guna2HtmlLabel9
            // 
            this.guna2HtmlLabel9.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel9.Location = new System.Drawing.Point(484, 156);
            this.guna2HtmlLabel9.Name = "guna2HtmlLabel9";
            this.guna2HtmlLabel9.Size = new System.Drawing.Size(121, 15);
            this.guna2HtmlLabel9.TabIndex = 19;
            this.guna2HtmlLabel9.Text = "Konaklama Türü Seçiniz:";
            // 
            // guna2HtmlLabel10
            // 
            this.guna2HtmlLabel10.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel10.Location = new System.Drawing.Point(484, 225);
            this.guna2HtmlLabel10.Name = "guna2HtmlLabel10";
            this.guna2HtmlLabel10.Size = new System.Drawing.Size(55, 15);
            this.guna2HtmlLabel10.TabIndex = 20;
            this.guna2HtmlLabel10.Text = "Giriş Tarihi:";
            // 
            // guna2HtmlLabel11
            // 
            this.guna2HtmlLabel11.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel11.Location = new System.Drawing.Point(484, 294);
            this.guna2HtmlLabel11.Name = "guna2HtmlLabel11";
            this.guna2HtmlLabel11.Size = new System.Drawing.Size(57, 15);
            this.guna2HtmlLabel11.TabIndex = 21;
            this.guna2HtmlLabel11.Text = "Çıkış  Tarihi:";
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 10;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(65)))), ((int)(((byte)(50)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(549, 408);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(145, 42);
            this.guna2Button1.TabIndex = 22;
            this.guna2Button1.Text = "Rezervasyon Yap";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.BorderRadius = 10;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(65)))), ((int)(((byte)(50)))));
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(805, 12);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(36, 31);
            this.guna2ControlBox1.TabIndex = 23;
            // 
            // Rezervasyon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(223)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(853, 488);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.guna2HtmlLabel11);
            this.Controls.Add(this.guna2HtmlLabel10);
            this.Controls.Add(this.guna2HtmlLabel9);
            this.Controls.Add(this.konaklamaTuru);
            this.Controls.Add(this.guna2HtmlLabel8);
            this.Controls.Add(this.guna2HtmlLabel7);
            this.Controls.Add(this.guna2HtmlLabel6);
            this.Controls.Add(this.guna2HtmlLabel5);
            this.Controls.Add(this.guna2HtmlLabel4);
            this.Controls.Add(this.tbGidecegiYer);
            this.Controls.Add(this.tbBulunduguYer);
            this.Controls.Add(this.cikisTarihi);
            this.Controls.Add(this.girisTarihi);
            this.Controls.Add(this.donusTarihi);
            this.Controls.Add(this.gidisTarihi);
            this.Controls.Add(this.ulasimTuru);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Rezervasyon";
            this.Text = "a";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2ComboBox ulasimTuru;
        private Guna.UI2.WinForms.Guna2DateTimePicker gidisTarihi;
        private Guna.UI2.WinForms.Guna2DateTimePicker donusTarihi;
        private Guna.UI2.WinForms.Guna2DateTimePicker girisTarihi;
        private Guna.UI2.WinForms.Guna2DateTimePicker cikisTarihi;
        private Guna.UI2.WinForms.Guna2TextBox tbBulunduguYer;
        private Guna.UI2.WinForms.Guna2TextBox tbGidecegiYer;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel6;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel7;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel8;
        private Guna.UI2.WinForms.Guna2ComboBox konaklamaTuru;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel9;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel10;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel11;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
    }
}