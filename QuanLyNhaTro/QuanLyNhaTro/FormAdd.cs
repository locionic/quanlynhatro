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
    public partial class FormAdd : Form
    {
        DBManager dbmanager;
        List<Control> danhsach;
        DataTable table;
        int countDanhSach;
        String query;
        SqlParameter[] listParamEx;
        List<List<TextBox>> danhsachTXT;
        public FormAdd(String type)
        {
            InitializeComponent();
            if (type.Equals("phongtro"))
            {
                var param1 = new SqlParameter("id1", SqlDbType.Char);
                var param2 = new SqlParameter("id2", SqlDbType.Int);
                var param3 = new SqlParameter("id3", SqlDbType.Int);
                var param4 = new SqlParameter("id4", SqlDbType.Int);
                List<SqlParameter> array = new List<SqlParameter>();
                array.Add(param1);
                array.Add(param2);
                array.Add(param3);
                array.Add(param4);
                listParamEx = array.ToArray();
                query = "insert into phongtro values(@id1,@id2,@id3,@id4)";
            }
            else if (type.Equals("khachtro"))
            {
                var param1 = new SqlParameter("id1", SqlDbType.Int);
                var param2 = new SqlParameter("id2", SqlDbType.VarChar);
                var param3 = new SqlParameter("id3", SqlDbType.VarChar);
                var param4 = new SqlParameter("id4", SqlDbType.Date);
                var param5 = new SqlParameter("id5", SqlDbType.VarChar);
                var param6 = new SqlParameter("id6", SqlDbType.Char);
                List<SqlParameter> array = new List<SqlParameter>();
                array.Add(param1);
                array.Add(param2);
                array.Add(param3);
                array.Add(param4);
                array.Add(param5);
                array.Add(param6);
                listParamEx = array.ToArray();
                query = "insert into khachtro values(@id1,@id2,@id3,@id4,@id5,@id6)";
            }
            else {
                var param1 = new SqlParameter("id1", SqlDbType.VarChar);
                var param2 = new SqlParameter("id2", SqlDbType.Float);
                var param3 = new SqlParameter("id3", SqlDbType.Float);
                var param4 = new SqlParameter("id4", SqlDbType.Float);
                var param5 = new SqlParameter("id5", SqlDbType.Float);
                var param6 = new SqlParameter("id6", SqlDbType.Char);
                List<SqlParameter> array = new List<SqlParameter>();
                array.Add(param1);
                array.Add(param2);
                array.Add(param3);
                array.Add(param4);
                array.Add(param5);
                array.Add(param6);
                listParamEx = array.ToArray();
                query = "insert into hoadon values(@id1,@id2,@id3,@id4,@id5,@id6)";
            }
            danhsach = new List<Control>();
            danhsachTXT = new List<List<TextBox>>();
            dbmanager = new DBManager();
            dbmanager.open();
            var param = new SqlParameter("type", SqlDbType.NVarChar);
            param.Value = type;
            SqlParameter[] listParam = { param };
            table = dbmanager.executeQuery("SELECT * FROM QuanLyNhaTro03.INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = @type", listParam);
            countDanhSach = 1;
            GroupBox gb = new GroupBox();
            List<TextBox> dstxt = new List<TextBox>();
            for (int j = 0; j < table.Rows.Count; j++)
            {
                Label label = new Label();
                label.Location = new System.Drawing.Point(5, 25 + j * 50);
                label.Name = "DanhSach";
                label.Text = table.Rows[j]["COLUMN_NAME"].ToString();
                label.AutoSize = true;
                gb.Controls.Add(label);

                TextBox txt = new TextBox();
                txt.Location = new System.Drawing.Point(75, 25 + j * 50);
                txt.Name = "DanhSach";
                txt.Size = new System.Drawing.Size(150, 20);
                txt.TabIndex = 7;
                gb.Controls.Add(txt);
                dstxt.Add(txt);
            }
            gb.Location = new System.Drawing.Point(25, 100);
            gb.Name = "groupBox2";
            gb.TabIndex = 1;
            gb.TabStop = false;
            gb.Text = "Đối tượng 1";
            gb.AutoSize = true;
            this.Controls.Add(gb);
            danhsach.Add(gb);
            danhsachTXT.Add(dstxt);
        }   

        private void NudSoLuong_ValueChanged(object sender, EventArgs e)
        {
            int count = Convert.ToInt32(nudSoLuong.Value);
            if (count < countDanhSach)
            {
                for (int i = 0; i < countDanhSach - count; i++)
                {
                    danhsach.Last().Dispose();
                    danhsach.RemoveAt(danhsach.Count - 1);
                }
                countDanhSach = count;
            }
            else
            {
                int time = (count - countDanhSach);
                for (int i = 0; i < time; i++)
                {
                    List<TextBox> dstxt = new List<TextBox>();
                    GroupBox gb = new GroupBox();
                    for (int j = 0; j < table.Rows.Count; j++)
                    {
                        Label label = new Label();
                        label.Location = new System.Drawing.Point(5, 25 + j * 50);
                        label.Name = "DanhSach";
                        label.Text = table.Rows[j]["COLUMN_NAME"].ToString();
                        label.AutoSize = true;
                        gb.Controls.Add(label);

                        TextBox txt = new TextBox();
                        txt.Location = new System.Drawing.Point(150, 25 + j * 50);
                        txt.Name = "danhSachTXT";
                        txt.Size = new System.Drawing.Size(150, 20);
                        txt.TabIndex = 7;
                        gb.Controls.Add(txt);
                        dstxt.Add(txt);
                    }
                    gb.Location = new System.Drawing.Point(25, danhsach.Last().Location.Y + danhsach.Last().Size.Height + 50);
                    gb.Name = "groupBox2";
                    gb.TabIndex = 1;
                    gb.TabStop = false;
                    gb.Text = "Đối tượng "+ (countDanhSach+1);
                    gb.AutoSize = true;
                    danhsach.Add(gb);
                    danhsachTXT.Add(dstxt);
                    this.Controls.Add(gb);
                    countDanhSach++;
                }
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            foreach (List<TextBox> ds in danhsachTXT)
            {
                for (int i = 0; i < listParamEx.Length; i++) {
                    listParamEx[i].Value = ds[i].Text;
                }
                dbmanager.executeQuery(query, listParamEx);
            }
        }
    }
}
