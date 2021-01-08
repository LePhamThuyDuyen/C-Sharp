namespace LinQThucHanhComputer
{
    partial class frmTimKiemAutocomlet
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTimKiemAutocomlet));
            this.lstDSPhong = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lvwDSMay = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radTheoCPU = new System.Windows.Forms.RadioButton();
            this.radTheoMa = new System.Windows.Forms.RadioButton();
            this.txtDULieuTim = new System.Windows.Forms.TextBox();
            this.btnThucHien = new System.Windows.Forms.Button();
            this.imgNho = new System.Windows.Forms.ImageList(this.components);
            this.imgLon = new System.Windows.Forms.ImageList(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstDSPhong
            // 
            this.lstDSPhong.FormattingEnabled = true;
            this.lstDSPhong.ItemHeight = 20;
            this.lstDSPhong.Location = new System.Drawing.Point(12, 27);
            this.lstDSPhong.Name = "lstDSPhong";
            this.lstDSPhong.Size = new System.Drawing.Size(186, 324);
            this.lstDSPhong.TabIndex = 0;
            this.lstDSPhong.SelectedIndexChanged += new System.EventHandler(this.lstDSPhong_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Danh sách Phòng";
            // 
            // lvwDSMay
            // 
            this.lvwDSMay.Location = new System.Drawing.Point(204, 12);
            this.lvwDSMay.Name = "lvwDSMay";
            this.lvwDSMay.Size = new System.Drawing.Size(576, 241);
            this.lvwDSMay.TabIndex = 3;
            this.lvwDSMay.UseCompatibleStateImageBehavior = false;
            this.lvwDSMay.View = System.Windows.Forms.View.Details;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(223, 256);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radTheoCPU);
            this.groupBox1.Controls.Add(this.radTheoMa);
            this.groupBox1.Controls.Add(this.txtDULieuTim);
            this.groupBox1.Controls.Add(this.btnThucHien);
            this.groupBox1.Location = new System.Drawing.Point(217, 268);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(390, 103);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin tìm kiếm";
            // 
            // radTheoCPU
            // 
            this.radTheoCPU.AutoSize = true;
            this.radTheoCPU.Location = new System.Drawing.Point(174, 21);
            this.radTheoCPU.Name = "radTheoCPU";
            this.radTheoCPU.Size = new System.Drawing.Size(125, 24);
            this.radTheoCPU.TabIndex = 9;
            this.radTheoCPU.TabStop = true;
            this.radTheoCPU.Text = "Tìm theo CPU";
            this.radTheoCPU.UseVisualStyleBackColor = true;
            this.radTheoCPU.CheckedChanged += new System.EventHandler(this.radTheoCPU_CheckedChanged);
            // 
            // radTheoMa
            // 
            this.radTheoMa.AutoSize = true;
            this.radTheoMa.Location = new System.Drawing.Point(8, 22);
            this.radTheoMa.Name = "radTheoMa";
            this.radTheoMa.Size = new System.Drawing.Size(151, 24);
            this.radTheoMa.TabIndex = 10;
            this.radTheoMa.TabStop = true;
            this.radTheoMa.Text = "Tìm Theo mã máy";
            this.radTheoMa.UseVisualStyleBackColor = true;
            this.radTheoMa.CheckedChanged += new System.EventHandler(this.radTheoMa_CheckedChanged);
            // 
            // txtDULieuTim
            // 
            this.txtDULieuTim.Location = new System.Drawing.Point(19, 55);
            this.txtDULieuTim.Name = "txtDULieuTim";
            this.txtDULieuTim.Size = new System.Drawing.Size(198, 26);
            this.txtDULieuTim.TabIndex = 8;
            this.txtDULieuTim.TextChanged += new System.EventHandler(this.txtDULieuTim_TextChanged);
            // 
            // btnThucHien
            // 
            this.btnThucHien.Location = new System.Drawing.Point(240, 48);
            this.btnThucHien.Name = "btnThucHien";
            this.btnThucHien.Size = new System.Drawing.Size(143, 33);
            this.btnThucHien.TabIndex = 7;
            this.btnThucHien.Text = "Thực Hiện";
            this.btnThucHien.UseVisualStyleBackColor = true;
            this.btnThucHien.Click += new System.EventHandler(this.btnThucHien_Click);
            // 
            // imgNho
            // 
            this.imgNho.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgNho.ImageStream")));
            this.imgNho.TransparentColor = System.Drawing.Color.Transparent;
            this.imgNho.Images.SetKeyName(0, "WinInstall.ico");
            // 
            // imgLon
            // 
            this.imgLon.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgLon.ImageStream")));
            this.imgLon.TransparentColor = System.Drawing.Color.Transparent;
            this.imgLon.Images.SetKeyName(0, "WinInstall.ico");
            // 
            // frmTimKiemAutocomlet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 425);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lvwDSMay);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstDSPhong);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmTimKiemAutocomlet";
            this.Text = "Tìm Kiếm Autocomplet";
            this.Load += new System.EventHandler(this.frmTimKiemAutocomlet_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstDSPhong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lvwDSMay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radTheoCPU;
        private System.Windows.Forms.RadioButton radTheoMa;
        private System.Windows.Forms.TextBox txtDULieuTim;
        private System.Windows.Forms.Button btnThucHien;
        private System.Windows.Forms.ImageList imgNho;
        private System.Windows.Forms.ImageList imgLon;
    }
}