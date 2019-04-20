using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaTro
{
    public partial class FormQuanLy : Form
    {
        DBManager dbmanager;
        List<Control> danhsach;
        String tablename;
        public FormQuanLy()
        {
            InitializeComponent();
            dbmanager = new DBManager();
            dbmanager.open();
            danhsach = new List<Control>();
            btnSearch.Enabled = false;
        }
        
        private void MenuPhongTro_Click(object sender, EventArgs e)
        {
            createView("Select * From Phongtro","phongtro");
            tablename = "phongtro";
        }

        private void MenuKhachTro_Click(object sender, EventArgs e)
        {
            createView("Select * From KhachTro","khachtro");
            tablename = "khachtro";
        }

        private void MenuHoaDon_Click(object sender, EventArgs e)
        {
            createView("Select * From HoaDon","hoadon");
            tablename = "hoadon";
        }
        private void MenuItemLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnCheck_Click(object sender, EventArgs e, String tablename, String id)
        {
            DataTable table;
            if (tablename.Equals("phongtro"))
            {
                var param = new SqlParameter("id", SqlDbType.Int);
                param.Value = id;
                SqlParameter[] listParam = { param };
                table = dbmanager.executeQuery("select * from phongtro where IDROOM = @id",listParam);
                FormPhongTro formTo = new FormPhongTro(table.Rows[0]);
                formTo.ShowDialog();
            }
            else if (tablename.Equals("khachtro"))
            {
                var param = new SqlParameter("id", SqlDbType.Int);
                param.Value = id;
                SqlParameter[] listParam = { param };
                table = dbmanager.executeQuery("select * from khachtro where CMND = @id", listParam);
                FormKhachTro formTo = new FormKhachTro(table.Rows[0]);
                formTo.ShowDialog();
            }
            else
            {
                var param = new SqlParameter("id", SqlDbType.VarChar);
                param.Value = id;
                SqlParameter[] listParam = { param };
                table = dbmanager.executeQuery("select * from hoadon where idhoadon = @id", listParam);
                FormHoaDon formTo = new FormHoaDon(table.Rows[0]);
                formTo.ShowDialog();
            }

        }
        private void createView(String query, String tablename) {
            btnSearch.Enabled = true;
            DataTable table = dbmanager.executeQuery("SELECT * FROM QuanLyNhaTro03.INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = \'" + tablename + "\'");
            cbbSearch.Items.Clear();
            foreach (DataRow row in table.Rows)
            {
                cbbSearch.Items.Add(row["COLUMN_NAME"]);
            }
            cbbSearch.SelectedIndex = 0;
            foreach (Control item in danhsach)
            {
                item.Dispose();
            }
            table = dbmanager.executeQuery(query);
            if (table.Rows.Count == 0)
            {
                Label label = new Label();
                label.Location = new System.Drawing.Point(100, 125);
                label.Name = "DanhSach";
                label.Text = "Không có kết quả";
                label.Size = new System.Drawing.Size(150, 20);
                danhsach.Add(label);
                this.Controls.Add(label);
            }
            else
            {
                for (int i = 0; i < table.Columns.Count; i++)
                {
                    Label label = new Label();
                    label.Location = new System.Drawing.Point(100 + i * 100, 125);
                    label.Name = "DanhSach";
                    label.Text = table.Columns[i].ColumnName;
                    label.Size = new System.Drawing.Size(100, 25);
                    danhsach.Add(label);
                    this.Controls.Add(label);
                }
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    DataRow row = table.Rows[i];
                    Button btn = new Button();
                    btn.Location = new System.Drawing.Point(25,150 + i * 25);
                    btn.Name = "DanhSach"+ row[0].ToString();
                    btn.Text = "Check";
                    btn.Click += (sender, EventArgs) => {btnCheck_Click(sender, EventArgs, tablename, row[0].ToString());};
                    btn.Size = new System.Drawing.Size(50,25);
                    danhsach.Add(btn);
                    this.Controls.Add(btn);
                    for (int j = 0; j < row.ItemArray.Length; j++)
                    {
                        Label label = new Label();
                        label.Location = new System.Drawing.Point(100 + j * 100, 150 + i * 25);
                        label.Name = "DanhSach" + row[0].ToString();
                        label.Text = row[j].ToString();
                        label.Size = new System.Drawing.Size(100, 25);
                        label.AutoSize = false;
                        danhsach.Add(label);
                        this.Controls.Add(label);
                    }
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            String type = "hoadon";
            if ((sender as ToolStripMenuItem).Text.Equals("Phòng"))
            {
                type = "phongtro";
            }
            else if ((sender as ToolStripMenuItem).Text.Equals("Khách Trọ"))
            {
                type = "khachtro";
            }
            FormAdd formAdd = new FormAdd(type);
            formAdd.ShowDialog();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {

            MessageBox.Show(cbbSearch.GetItemText(cbbSearch.SelectedItem).ToString());
            MessageBox.Show(txtSearch.Text);
            createView("select * from " + tablename + " where " + cbbSearch.GetItemText(cbbSearch.SelectedItem) + " = \'" + txtSearch.Text+"\'",tablename);
        }

        private void FormQuanLy_Load(object sender, EventArgs e)
        {

        }
    }
}