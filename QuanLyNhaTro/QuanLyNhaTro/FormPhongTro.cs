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
    public partial class FormPhongTro : Form
    {
        public FormPhongTro(DataRow data)
        {
            InitializeComponent();
            dbmanager = new DBManager();
            dbmanager.open();
            createView(Convert.ToInt32(data[0]));
        }
        DBManager dbmanager;
        private void createView(int id)
        {
            var param = new SqlParameter("id", SqlDbType.Char);
            param.Value = id;
            SqlParameter[] listParam = { param };
            DataTable table = dbmanager.executeQuery("select * from Khachtro where idroom = @id",listParam);
            if (table.Rows.Count == 0)
            {
                Label label = new Label();
                label.Location = new System.Drawing.Point(100, 125);
                label.Name = "DanhSach";
                label.Text = "Không có kết quả";
                label.Size = new System.Drawing.Size(150, 20);
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
                    label.Size = new System.Drawing.Size(75, 25);
                    this.Controls.Add(label);
                }
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    DataRow row = table.Rows[i];
                    Button btn = new Button();
                    btn.Location = new System.Drawing.Point(25, 150 + i * 25);
                    btn.Name = row[0].ToString();
                    btn.Text = "Check";
                    btn.Click += new System.EventHandler(this.btnCheck_Click);
                    btn.Size = new System.Drawing.Size(50, 25);
                    this.Controls.Add(btn);
                    for (int j = 0; j < row.ItemArray.Length; j++)
                    {
                        Label label = new Label();
                        label.Location = new System.Drawing.Point(100 + j * 100, 150 + i * 25);
                        label.Name = "DanhSach" + row[0].ToString();
                        label.Text = row[j].ToString();
                        label.Size = new System.Drawing.Size(50, 25);
                        label.AutoSize = true;
                        this.Controls.Add(label);
                    }
                }
            }
        }
        private void btnCheck_Click(object sender, EventArgs e)
        {
            var param = new SqlParameter("id", SqlDbType.Int);
            param.Value = (sender as Button).Name;
            SqlParameter[] listParam = { param };
            DataTable table = dbmanager.executeQuery("select * from khachtro where CMND = @id", listParam);
            FormKhachTro khachTro = new FormKhachTro(table.Rows[0]);
            khachTro.ShowDialog();
        }

        private void FormPhongTro_Load(object sender, EventArgs e)
        {

        }
    }


}
