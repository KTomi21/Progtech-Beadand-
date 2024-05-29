namespace Konyvtar_Rendszer_Kezeles
{
    partial class iranyitopultAblak
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(iranyitopultAblak));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            comboBoxKeresesiTipus = new ComboBox();
            textBoxKeresesiKriterium = new TextBox();
            buttonKereses = new Button();
            listBoxEredmenyek = new ListBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(17, 17);
            panel1.Name = "panel1";
            panel1.Size = new Size(844, 272);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-1, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(844, 268);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // comboBoxKeresesiTipus
            // 
            comboBoxKeresesiTipus.FormattingEnabled = true;
            comboBoxKeresesiTipus.Items.AddRange(new object[] { "Cím alapján", "Szerző alapján", "Kiadás dátuma szerint" });
            comboBoxKeresesiTipus.Location = new Point(173, 343);
            comboBoxKeresesiTipus.Margin = new Padding(3, 4, 3, 4);
            comboBoxKeresesiTipus.Name = "comboBoxKeresesiTipus";
            comboBoxKeresesiTipus.Size = new Size(196, 28);
            comboBoxKeresesiTipus.TabIndex = 1;
            // 
            // textBoxKeresesiKriterium
            // 
            textBoxKeresesiKriterium.Location = new Point(173, 397);
            textBoxKeresesiKriterium.Margin = new Padding(3, 4, 3, 4);
            textBoxKeresesiKriterium.Name = "textBoxKeresesiKriterium";
            textBoxKeresesiKriterium.Size = new Size(196, 27);
            textBoxKeresesiKriterium.TabIndex = 2;
            // 
            // buttonKereses
            // 
            buttonKereses.Location = new Point(217, 446);
            buttonKereses.Margin = new Padding(3, 4, 3, 4);
            buttonKereses.Name = "buttonKereses";
            buttonKereses.Size = new Size(106, 31);
            buttonKereses.TabIndex = 3;
            buttonKereses.Text = "Keresés";
            buttonKereses.UseVisualStyleBackColor = true;
            // 
            // listBoxEredmenyek
            // 
            listBoxEredmenyek.FormattingEnabled = true;
            listBoxEredmenyek.Location = new Point(436, 330);
            listBoxEredmenyek.Margin = new Padding(3, 4, 3, 4);
            listBoxEredmenyek.Name = "listBoxEredmenyek";
            listBoxEredmenyek.Size = new Size(198, 124);
            listBoxEredmenyek.TabIndex = 4;
            // 
            // iranyitopultAblak
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(listBoxEredmenyek);
            Controls.Add(buttonKereses);
            Controls.Add(textBoxKeresesiKriterium);
            Controls.Add(comboBoxKeresesiTipus);
            Controls.Add(panel1);
            Name = "iranyitopultAblak";
            Size = new Size(880, 565);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private ComboBox comboBoxKeresesiTipus;
        private TextBox textBoxKeresesiKriterium;
        private Button buttonKereses;
        private ListBox listBoxEredmenyek;
        private PictureBox pictureBox1;
    }
}
