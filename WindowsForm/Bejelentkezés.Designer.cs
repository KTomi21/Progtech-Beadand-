namespace Konyvtar_Rendszer_Kezeles
{
    partial class Bejelentkezés
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bejelentkezés));
            panel1 = new Panel();
            kilepes = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            felhasznalonevTextBox = new TextBox();
            jelszoTextBox = new TextBox();
            label4 = new Label();
            belepes = new Button();
            megjelenites = new CheckBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(14, 128, 87);
            panel1.Controls.Add(kilepes);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(320, 35);
            panel1.TabIndex = 0;
            // 
            // kilepes
            // 
            kilepes.AutoSize = true;
            kilepes.Cursor = Cursors.Hand;
            kilepes.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            kilepes.ForeColor = Color.White;
            kilepes.Location = new Point(301, 9);
            kilepes.Name = "kilepes";
            kilepes.Size = new Size(16, 16);
            kilepes.TabIndex = 0;
            kilepes.Text = "X";
            kilepes.Click += kilepes_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(107, 80);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 105);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(98, 200);
            label2.Name = "label2";
            label2.Size = new Size(118, 22);
            label2.TabIndex = 2;
            label2.Text = "Üdvözöljük!";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(51, 251);
            label3.Name = "label3";
            label3.Size = new Size(111, 18);
            label3.TabIndex = 3;
            label3.Text = "Felhasználónév:";
            // 
            // felhasznalonevTextBox
            // 
            felhasznalonevTextBox.Location = new Point(51, 280);
            felhasznalonevTextBox.Multiline = true;
            felhasznalonevTextBox.Name = "felhasznalonevTextBox";
            felhasznalonevTextBox.Size = new Size(221, 30);
            felhasznalonevTextBox.TabIndex = 4;
            // 
            // jelszoTextBox
            // 
            jelszoTextBox.Location = new Point(51, 355);
            jelszoTextBox.Multiline = true;
            jelszoTextBox.Name = "jelszoTextBox";
            jelszoTextBox.PasswordChar = '*';
            jelszoTextBox.Size = new Size(221, 30);
            jelszoTextBox.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(51, 326);
            label4.Name = "label4";
            label4.Size = new Size(51, 18);
            label4.TabIndex = 5;
            label4.Text = "Jelszó:";
            // 
            // belepes
            // 
            belepes.BackColor = Color.FromArgb(14, 128, 87);
            belepes.FlatAppearance.BorderColor = Color.Black;
            belepes.FlatStyle = FlatStyle.Popup;
            belepes.Font = new Font("Arial Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            belepes.ForeColor = Color.Black;
            belepes.Location = new Point(98, 434);
            belepes.Name = "belepes";
            belepes.Size = new Size(99, 31);
            belepes.TabIndex = 7;
            belepes.Text = "Belépés";
            belepes.UseVisualStyleBackColor = false;
            belepes.Click += belepes_Click;
            // 
            // megjelenites
            // 
            megjelenites.AutoSize = true;
            megjelenites.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            megjelenites.ForeColor = Color.Black;
            megjelenites.Location = new Point(135, 391);
            megjelenites.Name = "megjelenites";
            megjelenites.Size = new Size(137, 20);
            megjelenites.TabIndex = 8;
            megjelenites.Text = "Jelszó megjelenítés";
            megjelenites.UseVisualStyleBackColor = true;
            megjelenites.CheckedChanged += megjelenites_CheckedChanged;
            // 
            // Bejelentkezés
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(320, 525);
            Controls.Add(megjelenites);
            Controls.Add(belepes);
            Controls.Add(jelszoTextBox);
            Controls.Add(label4);
            Controls.Add(felhasznalonevTextBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Bejelentkezés";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bejelentkezés";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label kilepes;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label3;
        private TextBox felhasznalonevTextBox;
        private TextBox jelszoTextBox;
        private Label label4;
        private Button belepes;
        private CheckBox megjelenites;
    }
}