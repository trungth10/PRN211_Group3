using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesWinApp
{
    public partial class Main : Form
    {
        public bool isExit = true;
        public Main()
        {
            InitializeComponent();
            
        }



        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (isExit)
            {
                Application.Exit();
            }
        }



        public event EventHandler LogOut;
        private void btnLogout_Click(object sender, EventArgs e)
        {
            isExit = false;
            LogOut(this, new EventArgs());
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to close program", "Alert", MessageBoxButtons.YesNo) != DialogResult.No)
            {
                Application.Exit();
            }
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            switch (cmbOption.Text)
            {
                case "Order Management":
                    Orders frmOrders = new Orders();
                    frmOrders.Show();
                    this.Hide();
                    break;
                case "Member Management":
                    Members frmMembers = new Members();
                    frmMembers.Show();
                    this.Hide();
                    break;
                case "Product Management":
                    Products frmProducts = new Products();
                    frmProducts.Show();
                    this.Hide();
                    break;
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            cmbOption.SelectedIndex = 0;
        }

        
    }
}
