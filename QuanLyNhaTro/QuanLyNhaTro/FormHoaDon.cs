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
    public partial class FormHoaDon : Form
    {
        String query;
        public FormHoaDon(DataRow data)
        {
            InitializeComponent();
            //dbmanager = new DBManager();
            //dbmanager.open();
            txtID.Text = data[0].ToString();
            txtTienDien.Text = data[1].ToString();
            txtTienNuoc.Text = data[2].ToString();
            txtTienInternet.Text = data[3].ToString();
            txtSinhHoat.Text = data[4].ToString();
            txtPhong.Text = data[5].ToString();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            query = "update hoadon set IDHOADON=@id1, ELECTRICMONEY=@id2, WATERMONEY=@id3, INTERNETMONEY=@id4, LIVINGEXPENSE=@id5, idroom = @id6 where IDHOADON = \'" + txtID.Text+"\'";
            btnSua.Enabled = true;
            btnSua.Visible = true;
            txtID.Enabled = true;
            txtTienDien.Enabled = true;
            txtTienNuoc.Enabled = true;
            txtTienInternet.Enabled = true;
            txtSinhHoat.Enabled = true;
            txtPhong.Enabled = true;
        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnSua.Visible = false;
            DBManager dBManager = new DBManager();
            dBManager.open();
            var param1 = new SqlParameter("id1", SqlDbType.VarChar);
            param1.Value = txtID.Text;
            var param2 = new SqlParameter("id2", SqlDbType.Float);
            param2.Value = txtTienDien.Text;
            var param3 = new SqlParameter("id3", SqlDbType.Float);
            param3.Value = txtTienNuoc.Text;
            var param4 = new SqlParameter("id4", SqlDbType.Float);
            param4.Value = txtTienInternet.Text;
            var param5 = new SqlParameter("id5", SqlDbType.Float);
            param5.Value = txtSinhHoat.Text;
            var param6 = new SqlParameter("id6", SqlDbType.Char);
            param6.Value = txtPhong.Text;
            SqlParameter[] listParam = { param1, param2, param3, param4, param5, param6 };
            dBManager.executeQuery(query, listParam);
            dBManager.close();
            this.Close();
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            DBManager dBManager = new DBManager();
            dBManager.open();
            query = "delete from hoadon where IDHOADON = \'" + txtID.Text + "\'";
            dBManager.executeQuery(query);
            dBManager.close();
            this.Close();
        }
    }
}
