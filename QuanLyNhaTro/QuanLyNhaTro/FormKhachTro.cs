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
    public partial class FormKhachTro : Form
    {
        List<TextBox> dstxt = new List<TextBox>();
        String query;
        public FormKhachTro(DataRow data)
        {
            InitializeComponent();
            txtCMND.Text = data[0].ToString();
            txtDienThoai.Text = data[1].ToString();
            txtHoVaTen.Text = data[2].ToString();
            txtNgaySinh.Text = data[3].ToString();
            txtNoiSinh.Text = data[4].ToString();
            txtPhong.Text = data[5].ToString();
            dstxt.Add(txtCMND);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            query = "update khachtro set CMND=@id1, SDT=@id2, name=@id3, birthday=@id4, birthplace=@id5, idroom = @id6 where CMND = \'"+ txtCMND.Text+"\'";
            btnSua.Enabled = true;
            btnSua.Visible = true;
            txtCMND.Enabled = true;
            txtDienThoai.Enabled = true;
            txtHoVaTen.Enabled = true;
            txtNgaySinh.Enabled = true;
            txtNoiSinh.Enabled = true;
            txtPhong.Enabled = true;
        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnSua.Visible = false;
            DBManager dBManager = new DBManager();
            dBManager.open();
            var param1 = new SqlParameter("id1", SqlDbType.Int);
            param1.Value = txtCMND.Text;
            var param2 = new SqlParameter("id2", SqlDbType.VarChar);
            param2.Value = txtDienThoai.Text;
            var param3 = new SqlParameter("id3", SqlDbType.VarChar);
            param3.Value = txtHoVaTen.Text;
            var param4 = new SqlParameter("id4", SqlDbType.Date);
            param4.Value = txtNgaySinh.Text;
            var param5 = new SqlParameter("id5", SqlDbType.VarChar);
            param5.Value = txtNoiSinh.Text;
            var param6 = new SqlParameter("id6", SqlDbType.Char);
            param6.Value = txtPhong.Text;
            SqlParameter[] listParam = { param1, param2, param3, param4, param5, param6 };
            dBManager.executeQuery(query,listParam);
            dBManager.close();
            this.Close();
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            DBManager dBManager = new DBManager();
            dBManager.open();
            query = "delete from khachtro where CMND = \'" + txtCMND.Text + "\'";
            dBManager.executeQuery(query);
            dBManager.close();
            this.Close();
        }
    }
}
