namespace QuanLyNhaTro
{
    partial class FormQuanLy
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
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cbbSearch = new System.Windows.Forms.ComboBox();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.menuItemQuanLy = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPhongTro = new System.Windows.Forms.ToolStripMenuItem();
            this.menuKhachTro = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHoaDon = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.addPhongTro = new System.Windows.Forms.ToolStripMenuItem();
            this.addKhachTro = new System.Windows.Forms.ToolStripMenuItem();
            this.addHoaDon = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemLogOut = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.menuStrip.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(319, 23);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 28);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(8, 23);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(132, 22);
            this.txtSearch.TabIndex = 1;
            // 
            // cbbSearch
            // 
            this.cbbSearch.FormattingEnabled = true;
            this.cbbSearch.Location = new System.Drawing.Point(149, 22);
            this.cbbSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbbSearch.Name = "cbbSearch";
            this.cbbSearch.Size = new System.Drawing.Size(160, 24);
            this.cbbSearch.TabIndex = 2;
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemQuanLy,
            this.menuItemAdd,
            this.menuItemLogOut});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(1067, 28);
            this.menuStrip.TabIndex = 3;
            this.menuStrip.Text = "menuStrip1";
            // 
            // menuItemQuanLy
            // 
            this.menuItemQuanLy.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuPhongTro,
            this.menuKhachTro,
            this.menuHoaDon});
            this.menuItemQuanLy.Name = "menuItemQuanLy";
            this.menuItemQuanLy.Size = new System.Drawing.Size(73, 24);
            this.menuItemQuanLy.Text = "Quản Lý";
            // 
            // menuPhongTro
            // 
            this.menuPhongTro.Name = "menuPhongTro";
            this.menuPhongTro.Size = new System.Drawing.Size(149, 26);
            this.menuPhongTro.Text = "Phòng trọ";
            this.menuPhongTro.Click += new System.EventHandler(this.MenuPhongTro_Click);
            // 
            // menuKhachTro
            // 
            this.menuKhachTro.Name = "menuKhachTro";
            this.menuKhachTro.Size = new System.Drawing.Size(149, 26);
            this.menuKhachTro.Text = "Khách trọ";
            this.menuKhachTro.Click += new System.EventHandler(this.MenuKhachTro_Click);
            // 
            // menuHoaDon
            // 
            this.menuHoaDon.Name = "menuHoaDon";
            this.menuHoaDon.Size = new System.Drawing.Size(149, 26);
            this.menuHoaDon.Text = "Hóa đơn";
            this.menuHoaDon.Click += new System.EventHandler(this.MenuHoaDon_Click);
            // 
            // menuItemAdd
            // 
            this.menuItemAdd.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addPhongTro,
            this.addKhachTro,
            this.addHoaDon});
            this.menuItemAdd.Name = "menuItemAdd";
            this.menuItemAdd.Size = new System.Drawing.Size(58, 24);
            this.menuItemAdd.Text = "Thêm";
            // 
            // addPhongTro
            // 
            this.addPhongTro.Name = "addPhongTro";
            this.addPhongTro.Size = new System.Drawing.Size(149, 26);
            this.addPhongTro.Text = "Phòng";
            this.addPhongTro.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // addKhachTro
            // 
            this.addKhachTro.Name = "addKhachTro";
            this.addKhachTro.Size = new System.Drawing.Size(149, 26);
            this.addKhachTro.Text = "Khách Trọ";
            this.addKhachTro.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // addHoaDon
            // 
            this.addHoaDon.Name = "addHoaDon";
            this.addHoaDon.Size = new System.Drawing.Size(149, 26);
            this.addHoaDon.Text = "Hóa Đơn";
            this.addHoaDon.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // menuItemLogOut
            // 
            this.menuItemLogOut.Name = "menuItemLogOut";
            this.menuItemLogOut.Size = new System.Drawing.Size(91, 24);
            this.menuItemLogOut.Text = "Đăng Xuất";
            this.menuItemLogOut.Click += new System.EventHandler(this.MenuItemLogOut_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSearch);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.cbbSearch);
            this.groupBox1.Location = new System.Drawing.Point(24, 43);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(431, 65);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm Kiếm";
            // 
            // FormQuanLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormQuanLy";
            this.Text = "Quản Lý Nhà Trọ";
            this.Load += new System.EventHandler(this.FormQuanLy_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox cbbSearch;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem menuItemQuanLy;
        private System.Windows.Forms.ToolStripMenuItem menuPhongTro;
        private System.Windows.Forms.ToolStripMenuItem menuKhachTro;
        private System.Windows.Forms.ToolStripMenuItem menuHoaDon;
        private System.Windows.Forms.ToolStripMenuItem menuItemLogOut;
        private System.Windows.Forms.ToolStripMenuItem menuItemAdd;
        private System.Windows.Forms.ToolStripMenuItem addPhongTro;
        private System.Windows.Forms.ToolStripMenuItem addKhachTro;
        private System.Windows.Forms.ToolStripMenuItem addHoaDon;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}