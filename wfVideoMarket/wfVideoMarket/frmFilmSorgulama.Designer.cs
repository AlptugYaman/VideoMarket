namespace wfVideoMarket
{
    partial class frmFilmSorgulama
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
            this.txtAdaGore = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lvFilmler = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbFilmTurleri = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtAdaGore
            // 
            this.txtAdaGore.Location = new System.Drawing.Point(72, 59);
            this.txtAdaGore.Name = "txtAdaGore";
            this.txtAdaGore.Size = new System.Drawing.Size(146, 20);
            this.txtAdaGore.TabIndex = 35;
            this.txtAdaGore.TextChanged += new System.EventHandler(this.txtAdaGore_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(89, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 34;
            this.label5.Text = "Film Adına Göre";
            // 
            // lvFilmler
            // 
            this.lvFilmler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.lvFilmler.FullRowSelect = true;
            this.lvFilmler.GridLines = true;
            this.lvFilmler.Location = new System.Drawing.Point(27, 126);
            this.lvFilmler.Name = "lvFilmler";
            this.lvFilmler.Size = new System.Drawing.Size(521, 249);
            this.lvFilmler.TabIndex = 36;
            this.lvFilmler.UseCompatibleStateImageBehavior = false;
            this.lvFilmler.View = System.Windows.Forms.View.Details;
            this.lvFilmler.DoubleClick += new System.EventHandler(this.lvFilmler_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "FilmNo";
            this.columnHeader1.Width = 47;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Film Adı";
            this.columnHeader2.Width = 80;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "FilmTürü";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "TurNo";
            this.columnHeader4.Width = 2;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Yönetmen";
            this.columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Oyuncular";
            this.columnHeader6.Width = 100;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Ozet";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Miktar";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(218, 59);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(102, 20);
            this.textBox1.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(220, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "Yönetmene Göre";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(320, 59);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(98, 20);
            this.textBox2.TabIndex = 40;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(322, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 39;
            this.label2.Text = "Oyunculara Göre";
            // 
            // cbFilmTurleri
            // 
            this.cbFilmTurleri.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilmTurleri.FormattingEnabled = true;
            this.cbFilmTurleri.Location = new System.Drawing.Point(445, 58);
            this.cbFilmTurleri.Name = "cbFilmTurleri";
            this.cbFilmTurleri.Size = new System.Drawing.Size(103, 21);
            this.cbFilmTurleri.TabIndex = 41;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(452, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 42;
            this.label3.Text = "Film Türüne Göre";
            // 
            // frmFilmSorgulama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(578, 483);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbFilmTurleri);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAdaGore);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lvFilmler);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmFilmSorgulama";
            this.Text = "Film Sorgulama";
            this.Load += new System.EventHandler(this.frmFilmSorgulama_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAdaGore;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListView lvFilmler;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbFilmTurleri;
        private System.Windows.Forms.Label label3;
    }
}