namespace LinQThucHanhComputer
{
    partial class frmMainQLMayTinh
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuUngDung = new System.Windows.Forms.ToolStripMenuItem();
            this.xemPhongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thongKeMayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.capNhatPhongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUngDungCapNhatMay = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.heThongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doiMàuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doiMatKhauToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuUngDung,
            this.heThongToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(585, 30);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuUngDung
            // 
            this.mnuUngDung.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xemPhongToolStripMenuItem,
            this.thongKeMayToolStripMenuItem,
            this.capNhatPhongToolStripMenuItem,
            this.mnuUngDungCapNhatMay,
            this.toolStripMenuItem1,
            this.thoátToolStripMenuItem});
            this.mnuUngDung.Name = "mnuUngDung";
            this.mnuUngDung.Size = new System.Drawing.Size(94, 24);
            this.mnuUngDung.Text = "Ung Dung";
            // 
            // xemPhongToolStripMenuItem
            // 
            this.xemPhongToolStripMenuItem.Name = "xemPhongToolStripMenuItem";
            this.xemPhongToolStripMenuItem.Size = new System.Drawing.Size(192, 24);
            this.xemPhongToolStripMenuItem.Text = "Xem Phong";
            // 
            // thongKeMayToolStripMenuItem
            // 
            this.thongKeMayToolStripMenuItem.Name = "thongKeMayToolStripMenuItem";
            this.thongKeMayToolStripMenuItem.Size = new System.Drawing.Size(192, 24);
            this.thongKeMayToolStripMenuItem.Text = "Thong ke May";
            // 
            // capNhatPhongToolStripMenuItem
            // 
            this.capNhatPhongToolStripMenuItem.Name = "capNhatPhongToolStripMenuItem";
            this.capNhatPhongToolStripMenuItem.Size = new System.Drawing.Size(192, 24);
            this.capNhatPhongToolStripMenuItem.Text = "Cap nhat phong";
            // 
            // mnuUngDungCapNhatMay
            // 
            this.mnuUngDungCapNhatMay.Name = "mnuUngDungCapNhatMay";
            this.mnuUngDungCapNhatMay.Size = new System.Drawing.Size(192, 24);
            this.mnuUngDungCapNhatMay.Text = "Cap nhật may";
            this.mnuUngDungCapNhatMay.Click += new System.EventHandler(this.mnuUngDungCapNhatMay_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(189, 6);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(192, 24);
            this.thoátToolStripMenuItem.Text = "Thoát";
            // 
            // heThongToolStripMenuItem
            // 
            this.heThongToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.doiMàuToolStripMenuItem,
            this.doiMatKhauToolStripMenuItem});
            this.heThongToolStripMenuItem.Name = "heThongToolStripMenuItem";
            this.heThongToolStripMenuItem.Size = new System.Drawing.Size(91, 24);
            this.heThongToolStripMenuItem.Text = "He Thong";
            // 
            // doiMàuToolStripMenuItem
            // 
            this.doiMàuToolStripMenuItem.Name = "doiMàuToolStripMenuItem";
            this.doiMàuToolStripMenuItem.Size = new System.Drawing.Size(174, 24);
            this.doiMàuToolStripMenuItem.Text = "Doi Màu";
            // 
            // doiMatKhauToolStripMenuItem
            // 
            this.doiMatKhauToolStripMenuItem.Name = "doiMatKhauToolStripMenuItem";
            this.doiMatKhauToolStripMenuItem.Size = new System.Drawing.Size(174, 24);
            this.doiMatKhauToolStripMenuItem.Text = "Doi Mat Khau";
            // 
            // frmMainQLMayTinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 433);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "frmMainQLMayTinh";
            this.Text = "frmMainQLMayTinh";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMainQLMayTinh_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuUngDung;
        private System.Windows.Forms.ToolStripMenuItem xemPhongToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thongKeMayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem capNhatPhongToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuUngDungCapNhatMay;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem heThongToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doiMàuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doiMatKhauToolStripMenuItem;
    }
}