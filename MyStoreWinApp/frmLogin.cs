using DataAccess.MemberController;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessObject;
using DataAccess;

namespace MyStoreWinApp
{
    public partial class frmLogin : Form
    {
        IMember members = new MemberControll();
        public frmLogin()
        {
            InitializeComponent();
        }

       

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string password = txtPassword.Text;

            try
            {
                MemberObject loginMember = members.Login(email, password);
                if (loginMember != null)
                {
                    this.Hide();
                    frmMemberManagement frmMemberManagement = new frmMemberManagement(loginMember);
                    frmMemberManagement.ShowDialog();
                    this.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Login");
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
