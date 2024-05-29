namespace Konyvtar_Rendszer_Kezeles
{
    partial class Főablak
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Főablak));
            panel1 = new Panel();
            label1 = new Label();
            kilepes = new Label();
            panel2 = new Panel();
            label2 = new Label();
            kijelentkezes = new Button();
            visszahozottKonyv = new Button();
            udv_label = new Label();
            pictureBox1 = new PictureBox();
            kiadottKonyv = new Button();
            konyvHozzaadasa = new Button();
            iranyitopult = new Button();
            panel3 = new Panel();
            iranyitopultAblak1 = new iranyitopultAblak();
            konyHozzaadasaAblak1 = new konyHozzaadasaAblak();
            kiadottKonyvAblak1 = new kiadottKonyvAblak();
            visszaHozottKönyvek1 = new visszahozottKonyvAblak();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(14, 128, 87);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(kilepes);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1099, 35);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(0, 4);
            label1.Name = "label1";
            label1.Size = new Size(276, 22);
            label1.TabIndex = 1;
            label1.Text = "Könyvtárkezelő rendszer | Főoldal";
            // 
            // kilepes
            // 
            kilepes.AutoSize = true;
            kilepes.Cursor = Cursors.Hand;
            kilepes.Font = new Font("Arial Narrow", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 238);
            kilepes.ForeColor = SystemColors.Control;
            kilepes.Location = new Point(1075, 5);
            kilepes.Name = "kilepes";
            kilepes.RightToLeft = RightToLeft.No;
            kilepes.Size = new Size(19, 22);
            kilepes.TabIndex = 0;
            kilepes.Text = "X";
            kilepes.Click += kilepes_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(14, 128, 87);
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label2);
            panel2.Controls.Add(kijelentkezes);
            panel2.Controls.Add(visszahozottKonyv);
            panel2.Controls.Add(udv_label);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(kiadottKonyv);
            panel2.Controls.Add(konyvHozzaadasa);
            panel2.Controls.Add(iranyitopult);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 35);
            panel2.Name = "panel2";
            panel2.Size = new Size(220, 565);
            panel2.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label2.Location = new Point(61, 517);
            label2.Name = "label2";
            label2.Size = new Size(124, 21);
            label2.TabIndex = 9;
            label2.Text = "Kijelentkezés";
            // 
            // kijelentkezes
            // 
            kijelentkezes.BackColor = Color.White;
            kijelentkezes.FlatAppearance.BorderColor = Color.Black;
            kijelentkezes.FlatStyle = FlatStyle.Flat;
            kijelentkezes.ForeColor = SystemColors.Control;
            kijelentkezes.Image = (Image)resources.GetObject("kijelentkezes.Image");
            kijelentkezes.ImageAlign = ContentAlignment.MiddleRight;
            kijelentkezes.Location = new Point(11, 507);
            kijelentkezes.Name = "kijelentkezes";
            kijelentkezes.Size = new Size(46, 43);
            kijelentkezes.TabIndex = 8;
            kijelentkezes.UseVisualStyleBackColor = false;
            kijelentkezes.Click += kijelentkezes_Click;
            // 
            // visszahozottKonyv
            // 
            visszahozottKonyv.FlatAppearance.MouseDownBackColor = Color.DarkSeaGreen;
            visszahozottKonyv.FlatAppearance.MouseOverBackColor = Color.DarkSeaGreen;
            visszahozottKonyv.FlatStyle = FlatStyle.Flat;
            visszahozottKonyv.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            visszahozottKonyv.ForeColor = SystemColors.Control;
            visszahozottKonyv.Image = (Image)resources.GetObject("visszahozottKonyv.Image");
            visszahozottKonyv.ImageAlign = ContentAlignment.MiddleRight;
            visszahozottKonyv.Location = new Point(11, 357);
            visszahozottKonyv.Name = "visszahozottKonyv";
            visszahozottKonyv.Size = new Size(200, 45);
            visszahozottKonyv.TabIndex = 7;
            visszahozottKonyv.Text = "Visszahozott könyvek";
            visszahozottKonyv.TextAlign = ContentAlignment.MiddleLeft;
            visszahozottKonyv.UseVisualStyleBackColor = true;
            visszahozottKonyv.Click += visszahozottKonyv_Click;
            // 
            // udv_label
            // 
            udv_label.AutoSize = true;
            udv_label.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            udv_label.ForeColor = SystemColors.Control;
            udv_label.Location = new Point(57, 167);
            udv_label.Name = "udv_label";
            udv_label.Size = new Size(113, 24);
            udv_label.TabIndex = 3;
            udv_label.Text = "Üdvözöllek!";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(51, 17);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(114, 140);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // kiadottKonyv
            // 
            kiadottKonyv.FlatAppearance.MouseDownBackColor = Color.DarkSeaGreen;
            kiadottKonyv.FlatAppearance.MouseOverBackColor = Color.DarkSeaGreen;
            kiadottKonyv.FlatStyle = FlatStyle.Flat;
            kiadottKonyv.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            kiadottKonyv.ForeColor = SystemColors.Control;
            kiadottKonyv.Image = (Image)resources.GetObject("kiadottKonyv.Image");
            kiadottKonyv.ImageAlign = ContentAlignment.MiddleRight;
            kiadottKonyv.Location = new Point(11, 307);
            kiadottKonyv.Name = "kiadottKonyv";
            kiadottKonyv.Size = new Size(200, 45);
            kiadottKonyv.TabIndex = 6;
            kiadottKonyv.Text = "Kiadott könyvek";
            kiadottKonyv.TextAlign = ContentAlignment.MiddleLeft;
            kiadottKonyv.UseVisualStyleBackColor = true;
            kiadottKonyv.Click += kiadottKonyv_Click;
            // 
            // konyvHozzaadasa
            // 
            konyvHozzaadasa.FlatAppearance.MouseDownBackColor = Color.DarkSeaGreen;
            konyvHozzaadasa.FlatAppearance.MouseOverBackColor = Color.DarkSeaGreen;
            konyvHozzaadasa.FlatStyle = FlatStyle.Flat;
            konyvHozzaadasa.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            konyvHozzaadasa.ForeColor = SystemColors.Control;
            konyvHozzaadasa.Image = (Image)resources.GetObject("konyvHozzaadasa.Image");
            konyvHozzaadasa.ImageAlign = ContentAlignment.MiddleRight;
            konyvHozzaadasa.Location = new Point(11, 256);
            konyvHozzaadasa.Name = "konyvHozzaadasa";
            konyvHozzaadasa.Size = new Size(200, 45);
            konyvHozzaadasa.TabIndex = 5;
            konyvHozzaadasa.Text = "Könyv hozzáadása";
            konyvHozzaadasa.TextAlign = ContentAlignment.MiddleLeft;
            konyvHozzaadasa.UseVisualStyleBackColor = true;
            konyvHozzaadasa.Click += konyvHozzaadasa_Click;
            // 
            // iranyitopult
            // 
            iranyitopult.FlatAppearance.MouseDownBackColor = Color.DarkSeaGreen;
            iranyitopult.FlatAppearance.MouseOverBackColor = Color.DarkSeaGreen;
            iranyitopult.FlatStyle = FlatStyle.Flat;
            iranyitopult.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            iranyitopult.ForeColor = SystemColors.Control;
            iranyitopult.Location = new Point(11, 205);
            iranyitopult.Name = "iranyitopult";
            iranyitopult.Size = new Size(200, 45);
            iranyitopult.TabIndex = 4;
            iranyitopult.Text = "Irányítópult";
            iranyitopult.UseVisualStyleBackColor = true;
            iranyitopult.Click += iranyitopult_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(iranyitopultAblak1);
            panel3.Controls.Add(konyHozzaadasaAblak1);
            panel3.Controls.Add(kiadottKonyvAblak1);
            panel3.Controls.Add(visszaHozottKönyvek1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(220, 35);
            panel3.Name = "panel3";
            panel3.Size = new Size(879, 565);
            panel3.TabIndex = 2;
            // 
            // iranyitopultAblak1
            // 
            iranyitopultAblak1.Location = new Point(0, 0);
            iranyitopultAblak1.Name = "iranyitopultAblak1";
            iranyitopultAblak1.Size = new Size(880, 565);
            iranyitopultAblak1.TabIndex = 3;
            // 
            // konyHozzaadasaAblak1
            // 
            konyHozzaadasaAblak1.Location = new Point(0, 0);
            konyHozzaadasaAblak1.Name = "konyHozzaadasaAblak1";
            konyHozzaadasaAblak1.Size = new Size(880, 565);
            konyHozzaadasaAblak1.TabIndex = 2;
            // 
            // kiadottKonyvAblak1
            // 
            kiadottKonyvAblak1.Location = new Point(0, 0);
            kiadottKonyvAblak1.Name = "kiadottKonyvAblak1";
            kiadottKonyvAblak1.Size = new Size(880, 565);
            kiadottKonyvAblak1.TabIndex = 1;
            // 
            // visszaHozottKönyvek1
            // 
            visszaHozottKönyvek1.Location = new Point(0, 0);
            visszaHozottKönyvek1.Name = "visszaHozottKönyvek1";
            visszaHozottKönyvek1.Size = new Size(880, 565);
            visszaHozottKönyvek1.TabIndex = 0;
            // 
            // Főablak
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1099, 600);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Főablak";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Főablak";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label kilepes;
        private Label label1;
        private Panel panel2;
        private Label udv_label;
        private PictureBox pictureBox1;
        private Button iranyitopult;
        private Button konyvHozzaadasa;
        private Button visszahozottKonyv;
        private Button kiadottKonyv;
        private Button kijelentkezes;
        private Label label2;
        private Panel panel3;
        private visszahozottKonyvAblak visszaHozottKönyvek1;
        private iranyitopultAblak iranyitopultAblak1;
        private konyHozzaadasaAblak konyHozzaadasaAblak1;
        private kiadottKonyvAblak kiadottKonyvAblak1;
    }
}