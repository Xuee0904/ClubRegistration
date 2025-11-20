using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClubRegistration
{
    public partial class FrmClubRegistration : Form
    {
        private ClubRegistrationQuery clubRegistrationQuery;
        private int ID, age, count;
        private string FirstName, MiddleName, LastName, Gender, Program;
        private long StudentID;

        public FrmClubRegistration()
        {
            InitializeComponent();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            FrmUpdateMember updateMember = new FrmUpdateMember();

            updateMember.ShowDialog();
        }
    }
}
