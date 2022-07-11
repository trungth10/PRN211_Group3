using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess.Repository;
using BusinessObject;
using Microsoft.Extensions.Configuration;
using DataAccess.MemberController;

namespace MyStoreWinApp
{
    public partial class frmMemberManagement : Form
    {
        private MemberObject loginMember;
        private MemberControll memberControll = new MemberControll();
        private bool IsAdmin = false;
        Dictionary<string, string[]> CountryToCity = new Dictionary<string, string[]>();

        private BindingSource source;
        private void ClearText()
        {

            txtMemberID.Text = string.Empty;
            txtMemberName.Text = string.Empty;
            cboCity.SelectedIndex = 0;
            cboCountry.SelectedIndex = 0;
        }
        private void CheckAuthentication()
        {
            IConfiguration config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsetting.json", true, true)
                .Build();

            string adminEmail = config["DefaultAccounts:Email"];

            if (loginMember.Email == adminEmail)
            {
                IsAdmin = true;
            }
        }
        private MemberObject GetMemberObject()
        {
            MemberObject member = null;
            try
            {
                var currentRow = dgvMemberList.CurrentRow;
                member = new MemberObject
                {
                    MemberID = Convert.ToInt32(currentRow.Cells[0].Value),
                    MemberName = currentRow.Cells[1].Value.ToString(),
                    Email = currentRow.Cells[2].Value.ToString(),
                    Password = currentRow.Cells[3].Value.ToString(),
                    City = currentRow.Cells[4].Value.ToString(),
                    Country = currentRow.Cells[5].Value.ToString(),
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get member");
            }
            return member;
        }
        public void LoadMemberList(IEnumerable<MemberObject> list)
        {
            // CODE HERE
            try
            {
                source = new BindingSource();
                if (IsAdmin == false)
                {
                    source.DataSource =
                        new[] { memberControll.SearchMemberByID(loginMember.MemberID) };
                }
                else
                {
                    source.DataSource = list;
                }

                dgvMemberList.DataSource = null;
                dgvMemberList.DataSource = source;

                if (list.Count() == 0)
                {
                    ClearText();
                    btnDelete.Enabled = false;
                }
                else
                {
                    btnDelete.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load member list");
            }

        }

        public frmMemberManagement(MemberObject member)
        {
            this.loginMember = member;
            InitializeComponent();
            CountryToCity[""] = new string[] {
                "",
                "Hanoi",
                "Ho Chi Minh",
                "Da Nang",
                "Hue",
                "New York",
                "Washington",
                "Los Angeles",
                "San Francisco",
                "Las Vegas",
                "Chicago",
                "Shanghai",
                "Beijing",
                "Guangzhou",
                "Tianjin",
                "Chongqing",
                "Sydney",
                "Melbourne",
                "Perth",
                "Brisbane",
            };
            CountryToCity["Vietnam"] = new string[] {
                "",
                "Hanoi",
                "Ho Chi Minh",
                "Da Nang",
                "Hue",
            };
            CountryToCity["America"] = new string[] {
                "",
                "New York",
                "Washington",
                "Los Angeles",
                "San Francisco",
                "Las Vegas",
                "Chicago",
            };
            CountryToCity["China"] = new string[]
            {
                "",
                "Shanghai",
                "Beijing",
                "Guangzhou",
                "Tianjin",
                "Chongqing",
            };
            CountryToCity["Australia"] = new string[]
            {
                "",
                "Sydney",
                "Melbourne",
                "Perth",
                "Brisbane",
            };
        }

        private void frmMemberManagement_Load(object sender, EventArgs e)
        {
            CheckAuthentication();

            btnDelete.Enabled = false;

            cboCountry.SelectedIndex = 0;
            LoadCityComboBox();

            var memberList = memberControll.GetMemberList();
            LoadMemberList(memberList);
            dgvMemberList.CellDoubleClick += dgvMemberList_CellContentClick;
        }

        private void dgvMemberList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            frmInfo info = new frmInfo
            {
                Text = "Update Member",
                IsUpdate = true,
                memberInfo = GetMemberObject(),
                members = memberControll,
            };
            if (info.ShowDialog() == DialogResult.OK)
            {
                var memberList = memberControll.GetMemberList();
                LoadMemberList(memberList);
                source.Position = source.Count - 1;
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmInfo info = new frmInfo
            {
                Text = "Add member",
                IsUpdate = false,
                members = memberControll,
            };
            if (info.ShowDialog() == DialogResult.OK)
            {
                var memberList = memberControll.GetMemberList();
                LoadMemberList(memberList);
                source.Position = source.Count - 1;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                MemberObject member = GetMemberObject();
                memberControll.DeleteMember(member.MemberID);
                var memberList = memberControll.GetMemberList();
                LoadMemberList(memberList);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete member");
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtMemberID.Text))
            {
                try
                {
                    MemberObject searchMember = memberControll.SearchMemberByID(
                        int.Parse(txtMemberID.Text));
                    LoadMemberList(new[] { searchMember });
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Search by ID");
                }
            }
            else
            {
                try
                {
                    var searchNames = memberControll.SearchMemberByName(txtMemberName.Text);
                    var searchCity = memberControll.FilterMemberByCity(cboCity.Text);
                    var searchCountry = memberControll.FilterMemberByCountry(cboCountry.Text);
                    var resultSet = from names in searchNames
                                    join cities in searchCity
                                        on names.MemberID equals cities.MemberID
                                    join countries in searchCountry
                                        on names.MemberID equals countries.MemberID
                                    select new MemberObject
                                    {
                                        MemberID = names.MemberID,
                                        MemberName = names.MemberName,
                                        City = names.City,
                                        Country = names.Country,
                                        Email = names.Email,
                                        Password = names.Password,
                                    };
                    LoadMemberList(resultSet);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Search error");
                }
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

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

