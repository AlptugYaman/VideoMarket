namespace wfVideoMarket
{
    partial class frmSatisSorgulama
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
            this.dtpIlkTarih = new System.Windows.Forms.DateTimePicker();
            this.dtpSonTarih = new System.Windows.Forms.DateTimePicker();
            this.btnSorgula = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvSatislar = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.txtToplamTutar = new System.Windows.Forms.TextBox();
            this.txtToplamAdet = new System.Windows.Forms.TextBox();
            this.lblAdet = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSatislar)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpIlkTarih
            // 
            this.dtpIlkTarih.Location = new System.Drawing.Point(180, 55);
            this.dtpIlkTarih.Name = "dtpIlkTarih";
            this.dtpIlkTarih.Size = new System.Drawing.Size(110, 20);
            this.dtpIlkTarih.TabIndex = 0;
            // 
            // dtpSonTarih
            // 
            this.dtpSonTarih.Location = new System.Drawing.Point(325, 55);
            this.dtpSonTarih.Name = "dtpSonTarih";
            this.dtpSonTarih.Size = new System.Drawing.Size(110, 20);
            this.dtpSonTarih.TabIndex = 1;
            // 
            // btnSorgula
            // 
            this.btnSorgula.Location = new System.Drawing.Point(249, 96);
            this.btnSorgula.Name = "btnSorgula";
            this.btnSorgula.Size = new System.Drawing.Size(120, 23);
            this.btnSorgula.TabIndex = 2;
            this.btnSorgula.Text = "Satışları Sorgula";
            this.btnSorgula.UseVisualStyleBackColor = true;
            this.btnSorgula.Click += new System.EventHandler(this.btnSorgula_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(206, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "İlk Tarih";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(350, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Son Tarih";
            // 
            // dgvSatislar
            // 
            this.dgvSatislar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSatislar.Location = new System.Drawing.Point(38, 139);
            this.dgvSatislar.Name = "dgvSatislar";
            this.dgvSatislar.Size = new System.Drawing.Size(583, 241);
            this.dgvSatislar.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(94, 389);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 50;
            this.label7.Text = "Toplam";
            // 
            // txtToplamTutar
            // 
            this.txtToplamTutar.Location = new System.Drawing.Point(533, 386);
            this.txtToplamTutar.Name = "txtToplamTutar";
            this.txtToplamTutar.ReadOnly = true;
            this.txtToplamTutar.Size = new System.Drawing.Size(62, 20);
            this.txtToplamTutar.TabIndex = 49;
            this.txtToplamTutar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtToplamAdet
            // 
            this.txtToplamAdet.Location = new System.Drawing.Point(481, 386);
            this.txtToplamAdet.Name = "txtToplamAdet";
            this.txtToplamAdet.ReadOnly = true;
            this.txtToplamAdet.Size = new System.Drawing.Size(51, 20);
            this.txtToplamAdet.TabIndex = 48;
            this.txtToplamAdet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblAdet
            // 
            this.lblAdet.AutoSize = true;
            this.lblAdet.Location = new System.Drawing.Point(152, 389);
            this.lblAdet.Name = "lblAdet";
            this.lblAdet.Size = new System.Drawing.Size(0, 13);
            this.lblAdet.TabIndex = 51;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(181, 389);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 52;
            this.label4.Text = "adet listelendi";
            // 
            // frmSatisSorgulama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 453);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblAdet);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtToplamTutar);
            this.Controls.Add(this.txtToplamAdet);
            this.Controls.Add(this.dgvSatislar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSorgula);
            this.Controls.Add(this.dtpSonTarih);
            this.Controls.Add(this.dtpIlkTarih);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSatisSorgulama";
            this.Text = "Satış Sorgulama";
            this.Load += new System.EventHandler(this.frmSatisSorgulama_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSatislar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpIlkTarih;
        private System.Windows.Forms.DateTimePicker dtpSonTarih;
        private System.Windows.Forms.Button btnSorgula;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvSatislar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtToplamTutar;
        private System.Windows.Forms.TextBox txtToplamAdet;
        private System.Windows.Forms.Label lblAdet;
        private System.Windows.Forms.Label label4;
    }
}