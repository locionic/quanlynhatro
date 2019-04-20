using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaTro
{
    public partial class FormLogIn : Form
    {
        public FormLogIn()
        {
            InitializeComponent();
        }

        private void BtnLogIn_Click(object sender, EventArgs e)
        {
            DBManager dbmanager = new DBManager();
            dbmanager.open();
            try
            {
                DataTable table = dbmanager.executeQuery("Select username,password From account where username = \'" + txtUsername.Text + "\'" + "and password = \'"+txtPassword.Text+"\'");
                if (table.Rows.Count != 0)
                {
                    FormQuanLy mainForm = new FormQuanLy();
                    this.Hide();
                    mainForm.ShowDialog();
                    this.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
        }

        private void BtnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
