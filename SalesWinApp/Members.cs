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
using DataAccess.Models;

namespace SalesWinApp
{
    public partial class Members : Form
    {
        MemberAdding memberAdding = new MemberAdding();
        UserObject member = new UserObject();
        public Members()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            dgvMembers.DataSource = member.getMemberDTO();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            memberAdding.Show();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgvMembers.SelectedCells[0].Value.ToString());
            bool result = member.DeleteMember(id);
            if (result)
            {
                dgvMembers.DataSource = member.getMemberDTO();
            }
        }

        private void frmMembers_Load(object sender, EventArgs e)
        {
            dgvMembers.DataSource = member.getMemberDTO();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            int id = Convert.ToInt32(dgvMembers.SelectedCells[0].Value.ToString());
           
            TblMember paramMember = member.searchMememberByID(id);
            if(paramMember != null)
            {
                MemberUpdating update = new MemberUpdating(id, paramMember.Email, paramMember.Password, paramMember.Country, paramMember.City, paramMember.CompanyName);
                update.Show();
            }
            
        }

        private void dgvMembers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Main frmMain = new Main();
            frmMain.Show();
            this.Close();
        }
    }
}
