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
    public partial class MemberUpdating : Form
    {
        UserObject member = new UserObject();
        private int memberId;
        private string email, password, city, country, companyName;
        public MemberUpdating(int memberId, string email, string password, string city, string country, string companyName)
        {
            InitializeComponent();
            this.memberId = memberId;
            this.email = email; 
            this.password = password;
            this.city = city;
            this.country = country;
            this.companyName = companyName;


        }

        private void btnClose_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            bool result = member.UpdateMember(new DataAccess.Models.TblMember(Int32.Parse(txtMemberID.Text), txtEmail.Text, txtPassword.Text, txtCountry.Text, txtCity.Text
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

        private void MemberUpdating_Load(object sender, EventArgs e)
        {

        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MemberUpdating_Load_1(object sender, EventArgs e)
        {
            txtMemberID.Text = memberId.ToString();
            txtEmail.Text = email; 
            txtPassword.Text = password;    
            txtCity.Text = city;
            txtCountry.Text = country;
            txtCompanyName.Text = companyName;

        }
    }
}
