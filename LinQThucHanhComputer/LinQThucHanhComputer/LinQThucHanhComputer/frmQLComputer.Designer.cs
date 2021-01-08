namespace LinQThucHanhComputer
{
    partial class frmQLComputer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQLComputer));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.trePhong = new System.Windows.Forms.TreeView();
            this.btnThemPhong = new System.Windows.Forms.Button();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.lvwDSMay = new System.Windows.Forms.ListView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtPhong = new System.Windows.Forms.Label();
            this.btnTruyenDLHLoan = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMonitor = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtVGA = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtRam = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtHard = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCPU = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMsMay = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.imgTree = new System.Windows.Forms.ImageList(this.components);
            this.imgNho = new System.Windows.Forms.ImageList(this.components);
            this.imgLon = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.trePhong);
            this.splitContainer1.Panel1.Controls.Add(this.btnThemPhong);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1028, 571);
            this.splitContainer1.SplitterDistance = 261;
            this.splitContainer1.TabIndex = 0;
            // 
            // trePhong
            // 
            this.trePhong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trePhong.Location = new System.Drawing.Point(0, 0);
            this.trePhong.Name = "trePhong";
            this.trePhong.Size = new System.Drawing.Size(257, 533);
            this.trePhong.TabIndex = 1;
            this.trePhong.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.trePhong_AfterSelect);
            // 
            // btnThemPhong
            // 
            this.btnThemPhong.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnThemPhong.Location = new System.Drawing.Point(0, 533);
            this.btnThemPhong.Name = "btnThemPhong";
            this.btnThemPhong.Size = new System.Drawing.Size(257, 34);
            this.btnThemPhong.TabIndex = 0;
            this.btnThemPhong.Text = "Them Phong";
            this.btnThemPhong.UseVisualStyleBackColor = true;
            this.btnThemPhong.Click += new System.EventHandler(this.btnThemPhong_Click);
            // 
            // splitContainer2
            // 
            this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.lvwDSMay);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer2.Size = new System.Drawing.Size(763, 571);
            this.splitContainer2.SplitterDistance = 245;
            this.splitContainer2.TabIndex = 0;
            // 
            // lvwDSMay
            // 
            this.lvwDSMay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwDSMay.Location = new System.Drawing.Point(0, 0);
            this.lvwDSMay.Name = "lvwDSMay";
            this.lvwDSMay.Size = new System.Drawing.Size(759, 241);
            this.lvwDSMay.TabIndex = 2;
            this.lvwDSMay.UseCompatibleStateImageBehavior = false;
            this.lvwDSMay.SelectedIndexChanged += new System.EventHandler(this.lvwDSMay_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtPhong);
            this.groupBox2.Controls.Add(this.btnTruyenDLHLoan);
            this.groupBox2.Controls.Add(this.btnThoat);
            this.groupBox2.Controls.Add(this.btnXoa);
            this.groupBox2.Controls.Add(this.btnSua);
            this.groupBox2.Controls.Add(this.btnLuu);
            this.groupBox2.Controls.Add(this.btnTimKiem);
            this.groupBox2.Controls.Add(this.btnThem);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtMonitor);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtVGA);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtRam);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtHard);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtCPU);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtMsMay);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(759, 318);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin chi tiết";
            // 
            // txtPhong
            // 
            this.txtPhong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPhong.Location = new System.Drawing.Point(193, 234);
            this.txtPhong.Name = "txtPhong";
            this.txtPhong.Size = new System.Drawing.Size(424, 29);
            this.txtPhong.TabIndex = 6;
            this.txtPhong.Click += new System.EventHandler(this.txtPhong_Click);
            // 
            // btnTruyenDLHLoan
            // 
            this.btnTruyenDLHLoan.Location = new System.Drawing.Point(584, 281);
            this.btnTruyenDLHLoan.Name = "btnTruyenDLHLoan";
            this.btnTruyenDLHLoan.Size = new System.Drawing.Size(165, 34);
            this.btnTruyenDLHLoan.TabIndex = 10;
            this.btnTruyenDLHLoan.Text = "Truyền DL hỗn loạn";
            this.btnTruyenDLHLoan.UseVisualStyleBackColor = true;
            this.btnTruyenDLHLoan.Click += new System.EventHandler(this.btnTruyenDLHLoan_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(492, 281);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(86, 34);
            this.btnThoat.TabIndex = 10;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(308, 281);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(86, 34);
            this.btnXoa.TabIndex = 9;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(400, 281);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(86, 34);
            this.btnSua.TabIndex = 8;
            this.btnSua.Text = "Lưu Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(216, 286);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(86, 34);
            this.btnLuu.TabIndex = 8;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(3, 283);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(86, 34);
            this.btnTimKiem.TabIndex = 7;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(92, 283);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(118, 34);
            this.btnThem.TabIndex = 7;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(119, 234);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Phòng:";
            // 
            // txtMonitor
            // 
            this.txtMonitor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMonitor.Location = new System.Drawing.Point(191, 197);
            this.txtMonitor.Name = "txtMonitor";
            this.txtMonitor.Size = new System.Drawing.Size(426, 26);
            this.txtMonitor.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(110, 201);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Monitor:";
            // 
            // txtVGA
            // 
            this.txtVGA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtVGA.Location = new System.Drawing.Point(191, 164);
            this.txtVGA.Name = "txtVGA";
            this.txtVGA.Size = new System.Drawing.Size(426, 26);
            this.txtVGA.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(132, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "VGA:";
            // 
            // txtRam
            // 
            this.txtRam.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRam.Location = new System.Drawing.Point(191, 131);
            this.txtRam.Name = "txtRam";
            this.txtRam.Size = new System.Drawing.Size(426, 26);
            this.txtRam.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(131, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "RAM:";
            // 
            // txtHard
            // 
            this.txtHard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHard.Location = new System.Drawing.Point(191, 98);
            this.txtHard.Name = "txtHard";
            this.txtHard.Size = new System.Drawing.Size(426, 26);
            this.txtHard.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(102, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Harddisk:";
            // 
            // txtCPU
            // 
            this.txtCPU.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCPU.Location = new System.Drawing.Point(191, 65);
            this.txtCPU.Name = "txtCPU";
            this.txtCPU.Size = new System.Drawing.Size(426, 26);
            this.txtCPU.TabIndex = 1;
            this.txtCPU.Leave += new System.EventHandler(this.txtCPU_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(134, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "CPU:";
            // 
            // txtMsMay
            // 
            this.txtMsMay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMsMay.Location = new System.Drawing.Point(191, 32);
            this.txtMsMay.Name = "txtMsMay";
            this.txtMsMay.Size = new System.Drawing.Size(426, 26);
            this.txtMsMay.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã số máy:";
            // 
            // imgTree
            // 
            this.imgTree.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgTree.ImageStream")));
            this.imgTree.TransparentColor = System.Drawing.Color.Transparent;
            this.imgTree.Images.SetKeyName(0, "Cloud.ico");
            this.imgTree.Images.SetKeyName(1, "Box.ico");
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
            // frmQLComputer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 571);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmQLComputer";
            this.Text = "Quan Ly May Tinh";
            this.Load += new System.EventHandler(this.frmQLComputer_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView trePhong;
        private System.Windows.Forms.Button btnThemPhong;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.ListView lvwDSMay;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label txtPhong;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMonitor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtVGA;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtRam;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtHard;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCPU;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMsMay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnTruyenDLHLoan;
        private System.Windows.Forms.ImageList imgTree;
        private System.Windows.Forms.ImageList imgNho;
        private System.Windows.Forms.ImageList imgLon;
    }
}

