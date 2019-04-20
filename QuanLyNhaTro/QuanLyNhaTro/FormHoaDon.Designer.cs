namespace QuanLyNhaTro
{
    partial class FormHoaDon
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
            this.labelTienDien = new System.Windows.Forms.Label();
            this.labelTienNuoc = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.labelPhong = new System.Windows.Forms.Label();
            this.labelInternet = new System.Windows.Forms.Label();
            this.labelSinhHoat = new System.Windows.Forms.Label();
            this.txtPhong = new System.Windows.Forms.TextBox();
            this.txtTienDien = new System.Windows.Forms.TextBox();
            this.txtTienNuoc = new System.Windows.Forms.TextBox();
            this.txtTienInternet = new System.Windows.Forms.TextBox();
            this.txtSinhHoat = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.labelID = new System.Windows.Forms.Label();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTienDien
            // 
            this.labelTienDien.AutoSize = true;
            this.labelTienDien.Location = new System.Drawing.Point(25, 150);
            this.labelTienDien.Name = "labelTienDien";
            this.labelTienDien.Size = new System.Drawing.Size(53, 13);
            this.labelTienDien.TabIndex = 1;
            this.labelTienDien.Text = "Tiền Điện";
            // 
            // labelTienNuoc
            // 
            this.labelTienNuoc.AutoSize = true;
            this.labelTienNuoc.Location = new System.Drawing.Point(25, 200);
            this.labelTienNuoc.Name = "labelTienNuoc";
            this.labelTienNuoc.Size = new System.Drawing.Size(57, 13);
            this.labelTienNuoc.TabIndex = 2;
            this.labelTienNuoc.Text = "Tiền Nước";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnEdit,
            this.btnXoa});
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
            // labelPhong
            // 
            this.labelPhong.AutoSize = true;
            this.labelPhong.Location = new System.Drawing.Point(25, 100);
            this.labelPhong.Name = "labelPhong";
            this.labelPhong.Size = new System.Drawing.Size(38, 13);
            this.labelPhong.TabIndex = 4;
            this.labelPhong.Text = "Phòng";
            // 
            // labelInternet
            // 
            this.labelInternet.AutoSize = true;
            this.labelInternet.Location = new System.Drawing.Point(25, 250);
            this.labelInternet.Name = "labelInternet";
            this.labelInternet.Size = new System.Drawing.Size(67, 13);
            this.labelInternet.TabIndex = 5;
            this.labelInternet.Text = "Tiền Internet";
            // 
            // labelSinhHoat
            // 
            this.labelSinhHoat.AutoSize = true;
            this.labelSinhHoat.Location = new System.Drawing.Point(25, 300);
            this.labelSinhHoat.Name = "labelSinhHoat";
            this.labelSinhHoat.Size = new System.Drawing.Size(92, 13);
            this.labelSinhHoat.TabIndex = 6;
            this.labelSinhHoat.Text = "Chi Phí Sinh Hoạt";
            // 
            // txtPhong
            // 
            this.txtPhong.Enabled = false;
            this.txtPhong.Location = new System.Drawing.Point(125, 100);
            this.txtPhong.Name = "txtPhong";
            this.txtPhong.Size = new System.Drawing.Size(150, 20);
            this.txtPhong.TabIndex = 7;
            // 
            // txtTienDien
            // 
            this.txtTienDien.Enabled = false;
            this.txtTienDien.Location = new System.Drawing.Point(125, 150);
            this.txtTienDien.Name = "txtTienDien";
            this.txtTienDien.Size = new System.Drawing.Size(150, 20);
            this.txtTienDien.TabIndex = 8;
            // 
            // txtTienNuoc
            // 
            this.txtTienNuoc.Enabled = false;
            this.txtTienNuoc.Location = new System.Drawing.Point(125, 200);
            this.txtTienNuoc.Name = "txtTienNuoc";
            this.txtTienNuoc.Size = new System.Drawing.Size(150, 20);
            this.txtTienNuoc.TabIndex = 9;
            // 
            // txtTienInternet
            // 
            this.txtTienInternet.Enabled = false;
            this.txtTienInternet.Location = new System.Drawing.Point(125, 250);
            this.txtTienInternet.Name = "txtTienInternet";
            this.txtTienInternet.Size = new System.Drawing.Size(150, 20);
            this.txtTienInternet.TabIndex = 10;
            // 
            // txtSinhHoat
            // 
            this.txtSinhHoat.Enabled = false;
            this.txtSinhHoat.Location = new System.Drawing.Point(125, 300);
            this.txtSinhHoat.Name = "txtSinhHoat";
            this.txtSinhHoat.Size = new System.Drawing.Size(150, 20);
            this.txtSinhHoat.TabIndex = 11;
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(125, 50);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(150, 20);
            this.txtID.TabIndex = 12;
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(25, 50);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(18, 13);
            this.labelID.TabIndex = 13;
            this.labelID.Text = "ID";
            // 
            // btnSua
            // 
            this.btnSua.Enabled = false;
            this.btnSua.Location = new System.Drawing.Point(42, 364);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 14;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.BtnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(39, 20);
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.BtnXoa_Click);
            // 
            // FormHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtSinhHoat);
            this.Controls.Add(this.txtTienInternet);
            this.Controls.Add(this.txtTienNuoc);
            this.Controls.Add(this.txtTienDien);
            this.Controls.Add(this.txtPhong);
            this.Controls.Add(this.labelSinhHoat);
            this.Controls.Add(this.labelInternet);
            this.Controls.Add(this.labelPhong);
            this.Controls.Add(this.labelTienNuoc);
            this.Controls.Add(this.labelTienDien);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormHoaDon";
            this.Text = "KhachTro";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelTienDien;
        private System.Windows.Forms.Label labelTienNuoc;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnEdit;
        private System.Windows.Forms.Label labelPhong;
        private System.Windows.Forms.Label labelInternet;
        private System.Windows.Forms.Label labelSinhHoat;
        private System.Windows.Forms.TextBox txtPhong;
        private System.Windows.Forms.TextBox txtTienDien;
        private System.Windows.Forms.TextBox txtTienNuoc;
        private System.Windows.Forms.TextBox txtTienInternet;
        private System.Windows.Forms.TextBox txtSinhHoat;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.ToolStripMenuItem btnXoa;
    }
}