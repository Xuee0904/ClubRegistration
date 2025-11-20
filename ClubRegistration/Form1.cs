using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ClubRegistration
{
    public partial class FrmClubRegistration : Form
    {
        private ClubRegistrationQuery clubRegistrationQuery = new ClubRegistrationQuery();
        private int ID, Age, count;
        private string FirstName, MiddleName, LastName, Program;
        private long StudentID;

        public FrmClubRegistration()
        {
            InitializeComponent();
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            string Gender = MaleRadioBtn.Checked ? "Male" : "Female";

            clubRegistrationQuery.RegisterStudent(count, Convert.ToInt64(StudentIDTxt.Text), FirstNameTxt.Text, MiddleNameTxt.Text, LastNameTxt.Text,
                                                 Convert.ToInt32(AgeTxt.Text), Gender, ProgramCombo.Text);

            RefreshListOfClubMembers();
            ClearFields();
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            RefreshListOfClubMembers();
        }

        private void FrmClubRegistration_Load(object sender, EventArgs e)
        {
            RefreshListOfClubMembers();
        }


        private void UpdateButton_Click(object sender, EventArgs e)
        {
            FrmUpdateMember updateMember = new FrmUpdateMember();

            updateMember.ShowDialog();
        }

        public void RefreshListOfClubMembers()
        {
            clubRegistrationQuery.DisplayList();
            dataGridView1.DataSource = clubRegistrationQuery.bindingSource;
        }

        public int RegistrationID()
        {
            count++;
            return count;
        }

        public void ClearFields()
        {
            StudentIDTxt.Clear();
            FirstNameTxt.Clear();
            MiddleNameTxt.Clear();
            LastNameTxt.Clear();
            AgeTxt.Clear();
            ProgramCombo.SelectedIndex = -1;
            MaleRadioBtn.Checked = false;
            FemaleRadioBtn.Checked = false;
        }
    }
}
