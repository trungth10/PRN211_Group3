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

namespace SalesWinApp
{
    public partial class MemberAdding : Form
    {
        UserObject member = new UserObject();
        public MemberAdding()
        {
            InitializeComponent();
        }

        private void MemberAdding_Load(object sender, EventArgs e)
        {
           
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool result = member.AddMember(new DataAccess.Models.TblMember(Int32.Parse(txtMemberID.Text), txtEmail.Text, txtPassword.Text, txtCountry.Text, txtCity.Text
         , txtCompanyName.Text));
            if (result)
            {
                MessageBox.Show("Add Successfully");
            }
            else
            {

                MessageBox.Show("Add Fail Member " + txtMemberID.Text + "existed");
                //}

            }
        }
    }
}
