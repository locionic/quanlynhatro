namespace QuanLyNhaTro
{
    partial class FormKhachTro
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
            this.labelCMND = new System.Windows.Forms.Label();
            this.labelDienThoai = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.labelHoVatTen = new System.Windows.Forms.Label();
            this.labelNgaySinh = new System.Windows.Forms.Label();
            this.labelNoiSinh = new System.Windows.Forms.Label();
            this.txtHoVaTen = new System.Windows.Forms.TextBox();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.txtDienThoai = new System.Windows.Forms.TextBox();
            this.txtNgaySinh = new System.Windows.Forms.TextBox();
            this.txtNoiSinh = new System.Windows.Forms.TextBox();
            this.txtPhong = new System.Windows.Forms.TextBox();
            this.labelPhong = new System.Windows.Forms.Label();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelCMND
            // 
            this.labelCMND.AutoSize = true;
            this.labelCMND.Location = new System.Drawing.Point(25, 150);
            this.labelCMND.Name = "labelCMND";
            this.labelCMND.Size = new System.Drawing.Size(39, 13);
            this.labelCMND.TabIndex = 1;
            this.labelCMND.Text = "CMND";
            // 
            // labelDienThoai
            // 
            this.labelDienThoai.AutoSize = true;
            this.labelDienThoai.Location = new System.Drawing.Point(25, 200);
            this.labelDienThoai.Name = "labelDienThoai";
            this.labelDienThoai.Size = new System.Drawing.Size(59, 13);
            this.labelDienThoai.TabIndex = 2;
            this.labelDienThoai.Text = "Điện Thoại";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnEdit,
            this.btnRemove});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnEdit
            // 
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(73, 20);
            this.btnEdit.Text = "Chỉnh Sửa";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // labelHoVatTen
            // 
            this.labelHoVatTen.AutoSize = true;
            this.labelHoVatTen.Location = new System.Drawing.Point(25, 100);
            this.labelHoVatTen.Name = "labelHoVatTen";
            this.labelHoVatTen.Size = new System.Drawing.Size(59, 13);
            this.labelHoVatTen.TabIndex = 4;
            this.labelHoVatTen.Text = "Họ Và Tên";
            // 
            // labelNgaySinh
            // 
            this.labelNgaySinh.AutoSize = true;
            this.labelNgaySinh.Location = new System.Drawing.Point(25, 250);
            this.labelNgaySinh.Name = "labelNgaySinh";
            this.labelNgaySinh.Size = new System.Drawing.Size(56, 13);
            this.labelNgaySinh.TabIndex = 5;
            this.labelNgaySinh.Text = "Ngày Sinh";
            // 
            // labelNoiSinh
            // 
            this.labelNoiSinh.AutoSize = true;
            this.labelNoiSinh.Location = new System.Drawing.Point(25, 300);
            this.labelNoiSinh.Name = "labelNoiSinh";
            this.labelNoiSinh.Size = new System.Drawing.Size(47, 13);
            this.labelNoiSinh.TabIndex = 6;
            this.labelNoiSinh.Text = "Nơi Sinh";
            // 
            // txtHoVaTen
            // 
            this.txtHoVaTen.Enabled = false;
            this.txtHoVaTen.Location = new System.Drawing.Point(125, 100);
            this.txtHoVaTen.Name = "txtHoVaTen";
            this.txtHoVaTen.Size = new System.Drawing.Size(150, 20);
            this.txtHoVaTen.TabIndex = 7;
            // 
            // txtCMND
            // 
            this.txtCMND.Enabled = false;
            this.txtCMND.Location = new System.Drawing.Point(125, 150);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(150, 20);
            this.txtCMND.TabIndex = 8;
            // 
            // txtDienThoai
            // 
            this.txtDienThoai.Enabled = false;
            this.txtDienThoai.Location = new System.Drawing.Point(125, 200);
            this.txtDienThoai.Name = "txtDienThoai";
            this.txtDienThoai.Size = new System.Drawing.Size(150, 20);
            this.txtDienThoai.TabIndex = 9;
            // 
            // txtNgaySinh
            // 
            this.txtNgaySinh.Enabled = false;
            this.txtNgaySinh.Location = new System.Drawing.Point(125, 250);
            this.txtNgaySinh.Name = "txtNgaySinh";
            this.txtNgaySinh.Size = new System.Drawing.Size(150, 20);
            this.txtNgaySinh.TabIndex = 10;
            // 
            // txtNoiSinh
            // 
            this.txtNoiSinh.Enabled = false;
            this.txtNoiSinh.Location = new System.Drawing.Point(125, 300);
            this.txtNoiSinh.Name = "txtNoiSinh";
            this.txtNoiSinh.Size = new System.Drawing.Size(150, 20);
            this.txtNoiSinh.TabIndex = 11;
            // 
            // txtPhong
            // 
            this.txtPhong.Enabled = false;
            this.txtPhong.Location = new System.Drawing.Point(125, 50);
            this.txtPhong.Name = "txtPhong";
            this.txtPhong.Size = new System.Drawing.Size(150, 20);
            this.txtPhong.TabIndex = 12;
            // 
            // labelPhong
            // 
            this.labelPhong.AutoSize = true;
            this.labelPhong.Location = new System.Drawing.Point(25, 50);
            this.labelPhong.Name = "labelPhong";
            this.labelPhong.Size = new System.Drawing.Size(41, 13);
            this.labelPhong.TabIndex = 13;
            this.labelPhong.Text = "Phòng ";
            // 
            // btnSua
            // 
            this.btnSua.Enabled = false;
            this.btnSua.Location = new System.Drawing.Point(28, 371);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 14;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Visible = false;
            this.btnSua.Click += new System.EventHandler(this.BtnSua_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(39, 20);
            this.btnRemove.Text = "Xóa";
            this.btnRemove.Click += new System.EventHandler(this.BtnRemove_Click);
            // 
            // FormKhachTro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.labelPhong);
            this.Controls.Add(this.txtPhong);
            this.Controls.Add(this.txtNoiSinh);
            this.Controls.Add(this.txtNgaySinh);
            this.Controls.Add(this.txtDienThoai);
            this.Controls.Add(this.txtCMND);
            this.Controls.Add(this.txtHoVaTen);
            this.Controls.Add(this.labelNoiSinh);
            this.Controls.Add(this.labelNgaySinh);
            this.Controls.Add(this.labelHoVatTen);
            this.Controls.Add(this.labelDienThoai);
            this.Controls.Add(this.labelCMND);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormKhachTro";
            this.Text = "KhachTro";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelCMND;
        private System.Windows.Forms.Label labelDienThoai;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnEdit;
        private System.Windows.Forms.Label labelHoVatTen;
        private System.Windows.Forms.Label labelNgaySinh;
        private System.Windows.Forms.Label labelNoiSinh;
        private System.Windows.Forms.TextBox txtHoVaTen;
        private System.Windows.Forms.TextBox txtCMND;
        private System.Windows.Forms.TextBox txtDienThoai;
        private System.Windows.Forms.TextBox txtNgaySinh;
        private System.Windows.Forms.TextBox txtNoiSinh;
        private System.Windows.Forms.TextBox txtPhong;
        private System.Windows.Forms.Label labelPhong;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.ToolStripMenuItem btnRemove;
    }
}