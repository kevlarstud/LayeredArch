using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entities;
using AdmissionBAL;
using Exceptions;
using AdmissonDAL;

namespace StudentAdmission
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           if(!Page.IsPostBack)
            {
                BAL obj = new BAL();
                List<Institute> institueList = obj.getInstitute();
                List<Course> courseList = obj.getCourse();

                drpcity.Items.Clear();
                drpcity.Items.Add(new ListItem("Select campus city", "0"));
                drpcity.AppendDataBoundItems = true;
                drpcity.DataSource = institueList;
                drpcity.DataTextField = "instituteCity";
                drpcity.DataValueField = "instituteID";
                

                dropcname.Items.Clear();
                dropcname.Items.Add(new ListItem("Select course name", "0"));
                dropcname.AppendDataBoundItems = true;
                dropcname.DataSource = courseList;
                dropcname.DataTextField = "courseName";
                dropcname.DataValueField = "courseID";
                drpcity.DataBind();
                dropcname.DataBind();

            } 
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                student st = new student();
                st.studentName = txtname.Text;
                st.dob = Convert.ToDateTime(txtdob.Text);

                BAL bl = new BAL();
                bool result = bl.AddStud(st, Convert.ToInt32(dropcname.SelectedItem.Value), Convert.ToInt32(drpcity.SelectedItem.Value));
                if (result)
                {
                    Label4.Text = "Student added";
                }
                else
                {
                    Label4.Text = "Student no added";
                }
            }
            catch(Exception ex)
            {
                throw new AdmissionException(ex.Message);
            }
        }
    }
}