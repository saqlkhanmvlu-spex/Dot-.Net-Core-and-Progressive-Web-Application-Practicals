using System;
namespace CollegeAdmission
{
    public partial class Default : System.Web.UI.Page
    {
        protected void btnRegister_Click(object sender, EventArgs e)
        {
            lblResult.Text = "Congratulations! Your Admission is Successful.<br/><br/>";
            lblResult.Text += "Student Name : " + txtName.Text + "<br/>";
            lblResult.Text += "Gender : " + rblGender.SelectedValue + "<br/>";
            lblResult.Text += "DOB : " + Calendar1.SelectedDate.ToShortDateString() + "<br/>";
            lblResult.Text += "Email : " + txtEmail.Text + "<br/>";
            lblResult.Text += "Mobile : " + txtMobile.Text + "<br/>";
            lblResult.Text += "Course : " + ddlCourse.SelectedValue + "<br/>";
            lblResult.Text += "Percentage : " + txtPer.Text;
        }
        protected void btnReset_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtEmail.Text = "";
            txtMobile.Text = "";
            txtPer.Text = "";
            txtPass.Text = "";
            txtCPass.Text = "";
            rblGender.ClearSelection();
            ddlCourse.SelectedIndex = 0;
            Calendar1.SelectedDates.Clear();
            CheckBox1.Checked = false;
            lblResult.Text = "";
        }
    }
}
