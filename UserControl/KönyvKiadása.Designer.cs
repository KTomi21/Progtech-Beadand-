namespace Konyvtar_Rendszer_Kezeles
{
    partial class kiadottKonyvAblak
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
            textBox16 = new TextBox();
            textBox15 = new TextBox();
            torles = new Button();
            hozzaad = new Button();
            label2 = new Label();
            dateTimePicker12 = new DateTimePicker();
            dateTimePicker11 = new DateTimePicker();
            lbl_datum = new Label();
            lbl_szerzo = new Label();
            lbl_konyvcime = new Label();
            textBox13 = new TextBox();
            lbl_teloszam = new Label();
            textBox14 = new TextBox();
            lbl_email = new Label();
            textBox12 = new TextBox();
            lbl_nev = new Label();
            textBox11 = new TextBox();
            lbl_kiadott = new Label();
            panel2 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            dataGridView1 = new DataGridView();
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
            panel1.Controls.Add(textBox16);
            panel1.Controls.Add(textBox15);
            panel1.Controls.Add(torles);
            panel1.Controls.Add(hozzaad);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(dateTimePicker12);
            panel1.Controls.Add(dateTimePicker11);
            panel1.Controls.Add(lbl_datum);
            panel1.Controls.Add(lbl_szerzo);
            panel1.Controls.Add(lbl_konyvcime);
            panel1.Controls.Add(textBox13);
            panel1.Controls.Add(lbl_teloszam);
            panel1.Controls.Add(textBox14);
            panel1.Controls.Add(lbl_email);
            panel1.Controls.Add(textBox12);
            panel1.Controls.Add(lbl_nev);
            panel1.Controls.Add(textBox11);
            panel1.Controls.Add(lbl_kiadott);
            panel1.Location = new Point(21, 349);
            panel1.Name = "panel1";
            panel1.Size = new Size(843, 197);
            panel1.TabIndex = 0;
            // 
            // textBox16
            // 
            textBox16.Location = new Point(485, 65);
            textBox16.Name = "textBox16";
            textBox16.Size = new Size(247, 27);
            textBox16.TabIndex = 28;
            // 
            // textBox15
            // 
            textBox15.Location = new Point(520, 17);
            textBox15.Name = "textBox15";
            textBox15.Size = new Size(212, 27);
            textBox15.TabIndex = 27;
            // 
            // torles
            // 
            torles.BackColor = Color.FromArgb(14, 128, 87);
            torles.FlatAppearance.BorderSize = 0;
            torles.FlatStyle = FlatStyle.Flat;
            torles.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            torles.ForeColor = SystemColors.ButtonHighlight;
            torles.Location = new Point(30, 115);
            torles.Name = "torles";
            torles.Size = new Size(94, 37);
            torles.TabIndex = 26;
            torles.Text = "Törlés";
            torles.UseVisualStyleBackColor = false;
            torles.Click += torles_Click;
            // 
            // hozzaad
            // 
            hozzaad.BackColor = Color.FromArgb(14, 128, 87);
            hozzaad.FlatAppearance.BorderSize = 0;
            hozzaad.FlatStyle = FlatStyle.Flat;
            hozzaad.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            hozzaad.ForeColor = SystemColors.ButtonHighlight;
            hozzaad.Location = new Point(30, 51);
            hozzaad.Name = "hozzaad";
            hozzaad.Size = new Size(94, 37);
            hozzaad.TabIndex = 2;
            hozzaad.Text = "Hozzáad";
            hozzaad.UseVisualStyleBackColor = false;
            hozzaad.Click += hozzaad_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label2.Location = new Point(414, 156);
            label2.Name = "label2";
            label2.Size = new Size(68, 21);
            label2.TabIndex = 24;
            label2.Text = "Lejárat:";
            // 
            // dateTimePicker12
            // 
            dateTimePicker12.Location = new Point(482, 155);
            dateTimePicker12.Name = "dateTimePicker12";
            dateTimePicker12.Size = new Size(250, 27);
            dateTimePicker12.TabIndex = 23;
            // 
            // dateTimePicker11
            // 
            dateTimePicker11.Location = new Point(482, 113);
            dateTimePicker11.Name = "dateTimePicker11";
            dateTimePicker11.Size = new Size(250, 27);
            dateTimePicker11.TabIndex = 22;
            // 
            // lbl_datum
            // 
            lbl_datum.AutoSize = true;
            lbl_datum.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            lbl_datum.Location = new Point(414, 115);
            lbl_datum.Name = "lbl_datum";
            lbl_datum.Size = new Size(65, 21);
            lbl_datum.TabIndex = 21;
            lbl_datum.Text = "Kiadás:";
            // 
            // lbl_szerzo
            // 
            lbl_szerzo.AutoSize = true;
            lbl_szerzo.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 238);
            lbl_szerzo.Location = new Point(414, 67);
            lbl_szerzo.Name = "lbl_szerzo";
            lbl_szerzo.Size = new Size(65, 21);
            lbl_szerzo.TabIndex = 18;
            lbl_szerzo.Text = "Szerző:";
            // 
            // lbl_konyvcime
            // 
            lbl_konyvcime.AutoSize = true;
            lbl_konyvcime.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 238);
            lbl_konyvcime.Location = new Point(414, 19);
            lbl_konyvcime.Name = "lbl_konyvcime";
            lbl_konyvcime.Size = new Size(100, 21);
            lbl_konyvcime.TabIndex = 16;
            lbl_konyvcime.Text = "Könyv címe:";
            // 
            // textBox13
            // 
            textBox13.Location = new Point(265, 113);
            textBox13.Name = "textBox13";
            textBox13.Size = new Size(130, 27);
            textBox13.TabIndex = 15;
            // 
            // lbl_teloszam
            // 
            lbl_teloszam.AutoSize = true;
            lbl_teloszam.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 238);
            lbl_teloszam.Location = new Point(149, 115);
            lbl_teloszam.Name = "lbl_teloszam";
            lbl_teloszam.Size = new Size(110, 21);
            lbl_teloszam.TabIndex = 14;
            lbl_teloszam.Text = "Telefonszám:";
            // 
            // textBox14
            // 
            textBox14.Location = new Point(213, 155);
            textBox14.Name = "textBox14";
            textBox14.Size = new Size(182, 27);
            textBox14.TabIndex = 13;
            // 
            // lbl_email
            // 
            lbl_email.AutoSize = true;
            lbl_email.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 238);
            lbl_email.Location = new Point(149, 156);
            lbl_email.Name = "lbl_email";
            lbl_email.Size = new Size(57, 21);
            lbl_email.TabIndex = 12;
            lbl_email.Text = "Email:";
            // 
            // textBox12
            // 
            textBox12.Location = new Point(213, 65);
            textBox12.Name = "textBox12";
            textBox12.Size = new Size(182, 27);
            textBox12.TabIndex = 11;
            // 
            // lbl_nev
            // 
            lbl_nev.AutoSize = true;
            lbl_nev.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 238);
            lbl_nev.Location = new Point(149, 67);
            lbl_nev.Name = "lbl_nev";
            lbl_nev.Size = new Size(44, 21);
            lbl_nev.TabIndex = 10;
            lbl_nev.Text = "Név:";
            // 
            // textBox11
            // 
            textBox11.Location = new Point(251, 19);
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(143, 27);
            textBox11.TabIndex = 9;
            // 
            // lbl_kiadott
            // 
            lbl_kiadott.AutoSize = true;
            lbl_kiadott.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 238);
            lbl_kiadott.Location = new Point(149, 19);
            lbl_kiadott.Name = "lbl_kiadott";
            lbl_kiadott.Size = new Size(92, 21);
            lbl_kiadott.TabIndex = 8;
            lbl_kiadott.Text = "Kiadott ID:";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonHighlight;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(tableLayoutPanel1);
            panel2.Controls.Add(dataGridView1);
            panel2.Location = new Point(21, 13);
            panel2.Name = "panel2";
            panel2.Size = new Size(843, 329);
            panel2.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 6;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 8.103975F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 17.8899078F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 27.06422F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.93578F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24.0061169F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 62F));
            tableLayoutPanel1.Controls.Add(label7, 4, 0);
            tableLayoutPanel1.Controls.Add(label6, 3, 0);
            tableLayoutPanel1.Controls.Add(label5, 2, 0);
            tableLayoutPanel1.Controls.Add(label4, 1, 0);
            tableLayoutPanel1.Controls.Add(label3, 0, 0);
            tableLayoutPanel1.Location = new Point(17, 21);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 8;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 33F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 33F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 33F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 33F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 33F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 33F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 33F));
            tableLayoutPanel1.Size = new Size(809, 291);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Dock = DockStyle.Fill;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label7.Location = new Point(569, 0);
            label7.Name = "label7";
            label7.Size = new Size(173, 40);
            label7.TabIndex = 4;
            label7.Text = "Lejárat dátuma";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = DockStyle.Fill;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label6.Location = new Point(398, 0);
            label6.Name = "label6";
            label6.Size = new Size(165, 40);
            label6.TabIndex = 3;
            label6.Text = "Kiadás dátuma";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Fill;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label5.Location = new Point(196, 0);
            label5.Name = "label5";
            label5.Size = new Size(196, 40);
            label5.TabIndex = 2;
            label5.Text = "Könyv címe";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Fill;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label4.Location = new Point(63, 0);
            label4.Name = "label4";
            label4.Size = new Size(127, 40);
            label4.TabIndex = 1;
            label4.Text = "Név";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label3.Location = new Point(3, 0);
            label3.Name = "label3";
            label3.Size = new Size(54, 40);
            label3.TabIndex = 0;
            label3.Text = "ID";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(17, 21);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(809, 291);
            dataGridView1.TabIndex = 0;
            // 
            // kiadottKonyvAblak
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "kiadottKonyvAblak";
            Size = new Size(880, 565);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private DataGridView dataGridView1;
        private TextBox textBox14;
        private Label lbl_email;
        private TextBox textBox12;
        private Label lbl_nev;
        private TextBox textBox11;
        private Label lbl_kiadott;
        private TextBox textBox13;
        private Label lbl_teloszam;
        private Label lbl_szerzo;
        private Label lbl_konyvcime;
        private DateTimePicker dateTimePicker11;
        private Label lbl_datum;
        private Button hozzaad;
        private Label label2;
        private DateTimePicker dateTimePicker12;
        private Button torles;
        private TextBox textBox16;
        private TextBox textBox15;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label3;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
    }
}
