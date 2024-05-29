namespace Konyvtar_Rendszer_Kezeles
{
    partial class visszahozottKonyvAblak
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            comboBox21 = new ComboBox();
            lb_statusz = new Label();
            torles = new Button();
            visszavesz = new Button();
            textBox26 = new TextBox();
            lbl_szerzo = new Label();
            textBox25 = new TextBox();
            lbl_konyvcime = new Label();
            textBox24 = new TextBox();
            lbl_email = new Label();
            textBox23 = new TextBox();
            lbl_teloszam = new Label();
            textBox22 = new TextBox();
            lbl_nev = new Label();
            textBox21 = new TextBox();
            lbl_kiadott = new Label();
            panel2 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(comboBox21);
            panel1.Controls.Add(lb_statusz);
            panel1.Controls.Add(torles);
            panel1.Controls.Add(visszavesz);
            panel1.Controls.Add(textBox26);
            panel1.Controls.Add(lbl_szerzo);
            panel1.Controls.Add(textBox25);
            panel1.Controls.Add(lbl_konyvcime);
            panel1.Controls.Add(textBox24);
            panel1.Controls.Add(lbl_email);
            panel1.Controls.Add(textBox23);
            panel1.Controls.Add(lbl_teloszam);
            panel1.Controls.Add(textBox22);
            panel1.Controls.Add(lbl_nev);
            panel1.Controls.Add(textBox21);
            panel1.Controls.Add(lbl_kiadott);
            panel1.Location = new Point(13, 16);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(232, 365);
            panel1.TabIndex = 0;
            // 
            // comboBox21
            // 
            comboBox21.FormattingEnabled = true;
            comboBox21.Items.AddRange(new object[] { "Visszahozott", "Nincs visszahozva" });
            comboBox21.Location = new Point(72, 246);
            comboBox21.Margin = new Padding(3, 2, 3, 2);
            comboBox21.Name = "comboBox21";
            comboBox21.Size = new Size(148, 23);
            comboBox21.TabIndex = 17;
            // 
            // lb_statusz
            // 
            lb_statusz.AutoSize = true;
            lb_statusz.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 238);
            lb_statusz.Location = new Point(8, 248);
            lb_statusz.Name = "lb_statusz";
            lb_statusz.Size = new Size(58, 17);
            lb_statusz.TabIndex = 16;
            lb_statusz.Text = "Státusz:";
            // 
            // torles
            // 
            torles.BackColor = Color.FromArgb(14, 128, 87);
            torles.FlatAppearance.BorderSize = 0;
            torles.FlatAppearance.CheckedBackColor = Color.DarkSeaGreen;
            torles.FlatAppearance.MouseDownBackColor = Color.DarkSeaGreen;
            torles.FlatStyle = FlatStyle.Flat;
            torles.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            torles.ForeColor = SystemColors.ButtonHighlight;
            torles.Location = new Point(117, 301);
            torles.Margin = new Padding(3, 2, 3, 2);
            torles.Name = "torles";
            torles.Size = new Size(100, 44);
            torles.TabIndex = 15;
            torles.Text = "Törlés";
            torles.UseVisualStyleBackColor = false;
            torles.Click += torles_Click;
            // 
            // visszavesz
            // 
            visszavesz.BackColor = Color.FromArgb(14, 128, 87);
            visszavesz.FlatAppearance.BorderSize = 0;
            visszavesz.FlatAppearance.CheckedBackColor = Color.DarkSeaGreen;
            visszavesz.FlatAppearance.MouseDownBackColor = Color.DarkSeaGreen;
            visszavesz.FlatStyle = FlatStyle.Flat;
            visszavesz.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            visszavesz.ForeColor = SystemColors.ButtonHighlight;
            visszavesz.Location = new Point(13, 301);
            visszavesz.Margin = new Padding(3, 2, 3, 2);
            visszavesz.Name = "visszavesz";
            visszavesz.Size = new Size(85, 44);
            visszavesz.TabIndex = 14;
            visszavesz.Text = "Visszavesz";
            visszavesz.UseVisualStyleBackColor = false;
            visszavesz.Click += visszavesz_Click;
            // 
            // textBox26
            // 
            textBox26.Location = new Point(67, 206);
            textBox26.Margin = new Padding(3, 2, 3, 2);
            textBox26.Name = "textBox26";
            textBox26.Size = new Size(153, 23);
            textBox26.TabIndex = 11;
            // 
            // lbl_szerzo
            // 
            lbl_szerzo.AutoSize = true;
            lbl_szerzo.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 238);
            lbl_szerzo.Location = new Point(8, 208);
            lbl_szerzo.Name = "lbl_szerzo";
            lbl_szerzo.Size = new Size(53, 17);
            lbl_szerzo.TabIndex = 10;
            lbl_szerzo.Text = "Szerző:";
            // 
            // textBox25
            // 
            textBox25.Location = new Point(8, 175);
            textBox25.Margin = new Padding(3, 2, 3, 2);
            textBox25.Name = "textBox25";
            textBox25.Size = new Size(212, 23);
            textBox25.TabIndex = 9;
            // 
            // lbl_konyvcime
            // 
            lbl_konyvcime.AutoSize = true;
            lbl_konyvcime.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 238);
            lbl_konyvcime.Location = new Point(8, 157);
            lbl_konyvcime.Name = "lbl_konyvcime";
            lbl_konyvcime.Size = new Size(85, 17);
            lbl_konyvcime.TabIndex = 8;
            lbl_konyvcime.Text = "Könyv címe:";
            // 
            // textBox24
            // 
            textBox24.Location = new Point(58, 119);
            textBox24.Margin = new Padding(3, 2, 3, 2);
            textBox24.Name = "textBox24";
            textBox24.Size = new Size(162, 23);
            textBox24.TabIndex = 7;
            // 
            // lbl_email
            // 
            lbl_email.AutoSize = true;
            lbl_email.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 238);
            lbl_email.Location = new Point(8, 120);
            lbl_email.Name = "lbl_email";
            lbl_email.Size = new Size(44, 17);
            lbl_email.TabIndex = 6;
            lbl_email.Text = "Email:";
            // 
            // textBox23
            // 
            textBox23.Location = new Point(109, 85);
            textBox23.Margin = new Padding(3, 2, 3, 2);
            textBox23.Name = "textBox23";
            textBox23.Size = new Size(110, 23);
            textBox23.TabIndex = 5;
            // 
            // lbl_teloszam
            // 
            lbl_teloszam.AutoSize = true;
            lbl_teloszam.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 238);
            lbl_teloszam.Location = new Point(8, 86);
            lbl_teloszam.Name = "lbl_teloszam";
            lbl_teloszam.Size = new Size(88, 17);
            lbl_teloszam.TabIndex = 4;
            lbl_teloszam.Text = "Telefonszám:";
            // 
            // textBox22
            // 
            textBox22.Location = new Point(51, 49);
            textBox22.Margin = new Padding(3, 2, 3, 2);
            textBox22.Name = "textBox22";
            textBox22.Size = new Size(169, 23);
            textBox22.TabIndex = 3;
            // 
            // lbl_nev
            // 
            lbl_nev.AutoSize = true;
            lbl_nev.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 238);
            lbl_nev.Location = new Point(8, 50);
            lbl_nev.Name = "lbl_nev";
            lbl_nev.Size = new Size(37, 17);
            lbl_nev.TabIndex = 2;
            lbl_nev.Text = "Név:";
            // 
            // textBox21
            // 
            textBox21.Location = new Point(94, 17);
            textBox21.Margin = new Padding(3, 2, 3, 2);
            textBox21.Name = "textBox21";
            textBox21.Size = new Size(126, 23);
            textBox21.TabIndex = 1;
            // 
            // lbl_kiadott
            // 
            lbl_kiadott.AutoSize = true;
            lbl_kiadott.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 238);
            lbl_kiadott.Location = new Point(8, 19);
            lbl_kiadott.Name = "lbl_kiadott";
            lbl_kiadott.Size = new Size(74, 17);
            lbl_kiadott.TabIndex = 0;
            lbl_kiadott.Text = "Kiadott ID:";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonHighlight;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(tableLayoutPanel1);
            panel2.Controls.Add(dataGridView1);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(263, 16);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(495, 365);
            panel2.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 6;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19.2452831F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.64151F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 21.1320763F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 27.54717F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(label6, 4, 0);
            tableLayoutPanel1.Controls.Add(label5, 3, 0);
            tableLayoutPanel1.Controls.Add(label4, 2, 0);
            tableLayoutPanel1.Controls.Add(label3, 1, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 0);
            tableLayoutPanel1.Location = new Point(14, 44);
            tableLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 12;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tableLayoutPanel1.Size = new Size(464, 308);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = DockStyle.Fill;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label6.Location = new Point(338, 0);
            label6.Name = "label6";
            label6.Size = new Size(123, 30);
            label6.TabIndex = 4;
            label6.Text = "Státusz";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Fill;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label5.Location = new Point(241, 0);
            label5.Name = "label5";
            label5.Size = new Size(91, 30);
            label5.TabIndex = 3;
            label5.Text = "Szerző";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Fill;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label4.Location = new Point(137, 0);
            label4.Name = "label4";
            label4.Size = new Size(98, 30);
            label4.TabIndex = 2;
            label4.Text = "Köny címe";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label3.Location = new Point(49, 0);
            label3.Name = "label3";
            label3.Size = new Size(82, 30);
            label3.TabIndex = 1;
            label3.Text = "Név";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(40, 30);
            label2.TabIndex = 0;
            label2.Text = "ID";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(14, 44);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(464, 308);
            dataGridView1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label1.Location = new Point(14, 12);
            label1.Name = "label1";
            label1.Size = new Size(159, 19);
            label1.TabIndex = 0;
            label1.Text = "Visszahozott könyvek";
            // 
            // visszahozottKonyvAblak
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "visszahozottKonyvAblak";
            Size = new Size(770, 424);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private TextBox textBox22;
        private Label lbl_nev;
        private TextBox textBox21;
        private Label lbl_kiadott;
        private DataGridView dataGridView1;
        private TextBox textBox23;
        private Label lbl_teloszam;
        private TextBox textBox24;
        private Label lbl_email;
        private TextBox textBox26;
        private Label lbl_szerzo;
        private TextBox textBox25;
        private Label lbl_konyvcime;
        private Button torles;
        private Button visszavesz;
        private ComboBox comboBox21;
        private Label lb_statusz;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
    }
}
