namespace LinQThucHanhComputer
{
    partial class frmDuLieuHonLoan
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
            this.dgrHonLoan = new System.Windows.Forms.DataGridView();
            this.btnTheoMaPhong = new System.Windows.Forms.Button();
            this.btnOrderCoMa = new System.Windows.Forms.Button();
            this.btnCPUTuDau = new System.Windows.Forms.Button();
            this.btnCPUTuCuoi = new System.Windows.Forms.Button();
            this.txtGiaTri = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btncpuChuaDau = new System.Windows.Forms.Button();
            this.btnCPUCoChua = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgrHonLoan)).BeginInit();
            this.SuspendLayout();
            // 
            // dgrHonLoan
            // 
            this.dgrHonLoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrHonLoan.Location = new System.Drawing.Point(24, 12);
            this.dgrHonLoan.Name = "dgrHonLoan";
            this.dgrHonLoan.Size = new System.Drawing.Size(629, 276);
            this.dgrHonLoan.TabIndex = 0;
            // 
            // btnTheoMaPhong
            // 
            this.btnTheoMaPhong.Location = new System.Drawing.Point(659, 12);
            this.btnTheoMaPhong.Name = "btnTheoMaPhong";
            this.btnTheoMaPhong.Size = new System.Drawing.Size(203, 37);
            this.btnTheoMaPhong.TabIndex = 1;
            this.btnTheoMaPhong.Text = "Theo Mã Phòng";
            this.btnTheoMaPhong.UseVisualStyleBackColor = true;
            this.btnTheoMaPhong.Click += new System.EventHandler(this.btnTheoMaPhong_Click);
            // 
            // btnOrderCoMa
            // 
            this.btnOrderCoMa.Location = new System.Drawing.Point(659, 65);
            this.btnOrderCoMa.Name = "btnOrderCoMa";
            this.btnOrderCoMa.Size = new System.Drawing.Size(203, 37);
            this.btnOrderCoMa.TabIndex = 1;
            this.btnOrderCoMa.Text = "Mã Phòng Order";
            this.btnOrderCoMa.UseVisualStyleBackColor = true;
            this.btnOrderCoMa.Click += new System.EventHandler(this.btnOrderCoMa_Click);
            // 
            // btnCPUTuDau
            // 
            this.btnCPUTuDau.Location = new System.Drawing.Point(125, 310);
            this.btnCPUTuDau.Name = "btnCPUTuDau";
            this.btnCPUTuDau.Size = new System.Drawing.Size(191, 37);
            this.btnCPUTuDau.TabIndex = 1;
            this.btnCPUTuDau.Text = "CPU có tên đầu";
            this.btnCPUTuDau.UseVisualStyleBackColor = true;
            this.btnCPUTuDau.Click += new System.EventHandler(this.btnCPUTuDau_Click);
            // 
            // btnCPUTuCuoi
            // 
            this.btnCPUTuCuoi.Location = new System.Drawing.Point(609, 315);
            this.btnCPUTuCuoi.Name = "btnCPUTuCuoi";
            this.btnCPUTuCuoi.Size = new System.Drawing.Size(191, 37);
            this.btnCPUTuCuoi.TabIndex = 1;
            this.btnCPUTuCuoi.Text = "CPU có tên cuối";
            this.btnCPUTuCuoi.UseVisualStyleBackColor = true;
            this.btnCPUTuCuoi.Click += new System.EventHandler(this.btnCPUTuCuoi_Click);
            // 
            // txtGiaTri
            // 
            this.txtGiaTri.Location = new System.Drawing.Point(474, 315);
            this.txtGiaTri.Name = "txtGiaTri";
            this.txtGiaTri.Size = new System.Drawing.Size(115, 26);
            this.txtGiaTri.TabIndex = 2;
            this.txtGiaTri.Text = "Intel";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(355, 318);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tên đầu/cuối";
            // 
            // btncpuChuaDau
            // 
            this.btncpuChuaDau.Location = new System.Drawing.Point(125, 353);
            this.btncpuChuaDau.Name = "btncpuChuaDau";
            this.btncpuChuaDau.Size = new System.Drawing.Size(191, 37);
            this.btncpuChuaDau.TabIndex = 1;
            this.btncpuChuaDau.Text = "CPU có chứa đầu";
            this.btncpuChuaDau.UseVisualStyleBackColor = true;
            this.btncpuChuaDau.Click += new System.EventHandler(this.btncpuChuaDau_Click);
            // 
            // btnCPUCoChua
            // 
            this.btnCPUCoChua.Location = new System.Drawing.Point(609, 358);
            this.btnCPUCoChua.Name = "btnCPUCoChua";
            this.btnCPUCoChua.Size = new System.Drawing.Size(191, 37);
            this.btnCPUCoChua.TabIndex = 1;
            this.btnCPUCoChua.Text = "CPU có chứa";
            this.btnCPUCoChua.UseVisualStyleBackColor = true;
            this.btnCPUCoChua.Click += new System.EventHandler(this.btnCPUCoChua_Click);
            // 
            // frmDuLieuHonLoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 406);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtGiaTri);
            this.Controls.Add(this.btnCPUCoChua);
            this.Controls.Add(this.btnCPUTuCuoi);
            this.Controls.Add(this.btncpuChuaDau);
            this.Controls.Add(this.btnCPUTuDau);
            this.Controls.Add(this.btnOrderCoMa);
            this.Controls.Add(this.btnTheoMaPhong);
            this.Controls.Add(this.dgrHonLoan);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmDuLieuHonLoan";
            this.Text = "frmDuLieuHonLoan";
            this.Load += new System.EventHandler(this.frmDuLieuHonLoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgrHonLoan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgrHonLoan;
        private System.Windows.Forms.Button btnTheoMaPhong;
        private System.Windows.Forms.Button btnOrderCoMa;
        private System.Windows.Forms.Button btnCPUTuDau;
        private System.Windows.Forms.Button btnCPUTuCuoi;
        private System.Windows.Forms.TextBox txtGiaTri;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btncpuChuaDau;
        private System.Windows.Forms.Button btnCPUCoChua;
    }
}