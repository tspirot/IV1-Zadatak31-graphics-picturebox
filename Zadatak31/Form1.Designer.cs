namespace Zadatak31
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pictureBoxBoja = new System.Windows.Forms.PictureBox();
            this.radioButtonLinija = new System.Windows.Forms.RadioButton();
            this.radioButtonPravougaonik = new System.Windows.Forms.RadioButton();
            this.radioButtonElipsa = new System.Windows.Forms.RadioButton();
            this.listBoxDebljina = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBoja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBoxBoja);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(147, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Boja";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButtonElipsa);
            this.groupBox2.Controls.Add(this.radioButtonPravougaonik);
            this.groupBox2.Controls.Add(this.radioButtonLinija);
            this.groupBox2.Location = new System.Drawing.Point(13, 129);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(147, 160);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Oblik";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.listBoxDebljina);
            this.groupBox3.Location = new System.Drawing.Point(13, 312);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(147, 205);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Debljina olovke";
            // 
            // pictureBoxBoja
            // 
            this.pictureBoxBoja.BackColor = System.Drawing.Color.Black;
            this.pictureBoxBoja.Location = new System.Drawing.Point(15, 28);
            this.pictureBoxBoja.Name = "pictureBoxBoja";
            this.pictureBoxBoja.Size = new System.Drawing.Size(117, 48);
            this.pictureBoxBoja.TabIndex = 0;
            this.pictureBoxBoja.TabStop = false;
            this.pictureBoxBoja.Click += new System.EventHandler(this.pictureBoxBoja_Click);
            // 
            // radioButtonLinija
            // 
            this.radioButtonLinija.AutoSize = true;
            this.radioButtonLinija.Location = new System.Drawing.Point(15, 31);
            this.radioButtonLinija.Name = "radioButtonLinija";
            this.radioButtonLinija.Size = new System.Drawing.Size(59, 20);
            this.radioButtonLinija.TabIndex = 0;
            this.radioButtonLinija.TabStop = true;
            this.radioButtonLinija.Text = "Linija";
            this.radioButtonLinija.UseVisualStyleBackColor = true;
            // 
            // radioButtonPravougaonik
            // 
            this.radioButtonPravougaonik.AutoSize = true;
            this.radioButtonPravougaonik.Location = new System.Drawing.Point(15, 72);
            this.radioButtonPravougaonik.Name = "radioButtonPravougaonik";
            this.radioButtonPravougaonik.Size = new System.Drawing.Size(112, 20);
            this.radioButtonPravougaonik.TabIndex = 1;
            this.radioButtonPravougaonik.TabStop = true;
            this.radioButtonPravougaonik.Text = "Pravougaonik";
            this.radioButtonPravougaonik.UseVisualStyleBackColor = true;
            // 
            // radioButtonElipsa
            // 
            this.radioButtonElipsa.AutoSize = true;
            this.radioButtonElipsa.Location = new System.Drawing.Point(15, 115);
            this.radioButtonElipsa.Name = "radioButtonElipsa";
            this.radioButtonElipsa.Size = new System.Drawing.Size(66, 20);
            this.radioButtonElipsa.TabIndex = 2;
            this.radioButtonElipsa.TabStop = true;
            this.radioButtonElipsa.Text = "Elipsa";
            this.radioButtonElipsa.UseVisualStyleBackColor = true;
            // 
            // listBoxDebljina
            // 
            this.listBoxDebljina.FormattingEnabled = true;
            this.listBoxDebljina.ItemHeight = 16;
            this.listBoxDebljina.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20\t"});
            this.listBoxDebljina.Location = new System.Drawing.Point(21, 28);
            this.listBoxDebljina.Name = "listBoxDebljina";
            this.listBoxDebljina.Size = new System.Drawing.Size(110, 164);
            this.listBoxDebljina.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(183, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(701, 493);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 529);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBoja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBoxBoja;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButtonElipsa;
        private System.Windows.Forms.RadioButton radioButtonPravougaonik;
        private System.Windows.Forms.RadioButton radioButtonLinija;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox listBoxDebljina;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

