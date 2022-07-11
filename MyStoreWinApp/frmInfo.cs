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
using DataAccess.MemberController;

namespace MyStoreWinApp
{
    public partial class frmInfo : Form
    {
        public IMember members { get; set; }
        public bool IsUpdate { get; set; }
        public MemberObject memberInfo { get; set; }

        Dictionary<string, string[]> CountryToCity = new Dictionary<string, string[]>();
        public frmInfo()
        {
            InitializeComponent();
            CountryToCity["Vietnam"] = new string[] {
                "Hanoi",
                "Ho Chi Minh",
                "Da Nang",
                "Hue",
            };
            CountryToCity["America"] = new string[] {
                "New York",
                "Washington",
                "Los Angeles",
                "San Francisco",
                "Las Vegas",
                "Chicago",
            };
            CountryToCity["China"] = new string[]
            {
                "Shanghai",
                "Beijing",
                "Guangzhou",
                "Tianjin",
                "Chongqing",
            };
            CountryToCity["Australia"] = new string[]
            {
                "Sydney",
                "Melbourne",
                "Perth",
                "Brisbane",
            };
        }

        private void frmInfo_Load(object sender, EventArgs e)
        {
            try
            {
                cboCountry.SelectedIndex = 0;
                LoadCityComboBox();
                txtMemberID.Enabled = !IsUpdate;
                if (IsUpdate == true)
                {
                    txtMemberID.Text = memberInfo.MemberID.ToString();
                    txtMemberName.Text = memberInfo.MemberName;
                    txtEmail.Text = memberInfo.Email;
                    txtPassword.Text = memberInfo.Password;
                    cboCity.Text = memberInfo.City;
                    cboCountry.Text = memberInfo.Country;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load Infomation form");
            }


        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var member = new MemberObject
                {
                    MemberID = int.Parse(txtMemberID.Text),
                    MemberName = txtMemberName.Text,
                    Email = txtEmail.Text,
                    Password = txtPassword.Text,
                    City = cboCity.Text,
                    Country = cboCountry.Text,
                };
                if (IsUpdate == false)
                {
                    members.CreateMember(member);
                }
                else
                {
                    
                    members.UpdateMember(member);
                }
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, IsUpdate == false ? "Add Member" : "Update Member");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e) => Close();

        private void LoadCityComboBox()
        {
            cboCity.Items.Clear();
            if (cboCountry.SelectedIndex >= 0)
            {
                string country = cboCountry.Text;
                foreach (string city in CountryToCity[country])
                {
                    cboCity.Items.Add(city);
                }
                cboCity.SelectedIndex = 0;
            }
        }

        private void cboCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
           LoadCityComboBox();
        }
    }
}
