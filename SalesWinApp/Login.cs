using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess.Models;
using BusinessObject;
namespace SalesWinApp
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            UserObject memeber = new UserObject();
            TblMember result = memeber.Login(txtEmail.Text, txtPassword.Text);
            if (result != null)
            {
                Main frmMain = new Main();
                frmMain.Show();
                this.Hide();
                frmMain.LogOut += FrmMain_LogOut; 
            }
            else
            {
                MessageBox.Show("Email or password is inValid");
            }
                
            
        }

        private void FrmMain_LogOut(object? sender, EventArgs e)
        {
            (sender as Main).isExit = false;
            (sender as Main).Close();
            this.Show();
        }

        private void btnClose_Click(object sennder, EventArgs e)
        {
                Application.Exit();
        }

        
    }
}
