using BLL;
using DAL;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace ESSBC
{
    public partial class Default : System.Web.UI.Page
    {
        string _path;

        protected override void InitializeCulture()
        {
            if (Session["CurrentUI"] != null)
            {
                String selectedLanguage = (string)Session["CurrentUI"];
                UICulture = selectedLanguage;
                Culture = selectedLanguage;

                Thread.CurrentThread.CurrentCulture =
                    CultureInfo.CreateSpecificCulture(selectedLanguage);
                Thread.CurrentThread.CurrentUICulture = new
                    CultureInfo(selectedLanguage);

               
            }

            base.InitializeCulture();
        }


       

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["CurrentUI"] != null)
            {
                if (Session["CurrentUI"] == "ar-AE")
                {
                    rtl();
                }
            }

            _path = Path.Combine(
                    Request.PhysicalApplicationPath, "App_Data\\employees.xml");

            // Events registeration 
            this.btnDoWork.Click += btnDoWork_Click;
            this.btnCalcSalary.Click += btnCalcSalary_Click;
            this.btnArabic.Click += btnArabic_Click;
            this.btnEnglish.Click += btnEnglish_Click;
        }

       

       

        void btnCalcSalary_Click(object sender, EventArgs e)
        {
            Page.Validate();
            if (Page.IsValid)
            {
                EmployeeType type = GetEmployeeType();

                Employee emp = GetEmployee(type);

                WriteToXML(type, emp);

                lblSalary.Text = "Hourly Rate is: <strong>" + Decimal.Round(emp.HourlySalaryRate()).ToString() + "</strong>"; 
            }
            
        }



        void btnDoWork_Click(object sender, EventArgs e)
        {
             Page.Validate();

             if (Page.IsValid)
             {
                 EmployeeType type = GetEmployeeType();

                 Employee emp = GetEmployee(type);

                 WriteToXML(type, emp);

                 lblSalary.Text = "Work: <strong>" + emp.DoWork() + "</strong>"; 
             }
                
        }

        void btnEnglish_Click(object sender, EventArgs e)
        {
            Session["CurrentUI"] = "en-US";
            Response.Redirect(Request.Url.OriginalString);
        }

        void btnArabic_Click(object sender, EventArgs e)
        {
            Session["CurrentUI"] = "ar-AE";
            Response.Redirect(Request.Url.OriginalString);
        }

       


        // Helper methods 
        // Gets current selected employee type
        EmployeeType GetEmployeeType()
        {
            EmployeeType type = EmployeeType.Manager;
            if (rbAccountant.Checked)
                type = EmployeeType.Accountant;
            if (rbEngineer.Checked)
                type = EmployeeType.Engineer;
            if (rbWorker.Checked)
                type = EmployeeType.Worker; 

            return type; 
        }

        // This method write to xml file
        private void WriteToXML(EmployeeType type, Employee emp)
        {
            XMLManager.file = this._path;
            XMLManager.addEmployee(emp.ID.ToString(), emp.Name,
                emp.Salary.ToString(), emp.Age.ToString(), type.ToString());
        }

        // This method to return employee object
        private Employee GetEmployee(EmployeeType type)
        {
            IEmployee iemployee = EmployeeFactory.CreateEmployee(
                 type, txtName.Text, int.Parse(txtAge.Text),
                int.Parse(txtID.Text), decimal.Parse(txtSalary.Text));
            return iemployee as Employee;
        }

        // This method to reverse page direction
        private void rtl()
        {
            HtmlLink link = new HtmlLink();
            link.Attributes.Add("rel", "stylesheet");
            link.Attributes.Add("type", "text/css");
            link.Href = "/Content/rtl.css";
            link.Attributes.Add("media", "all");
            Page.Header.Controls.Add(link);
        }

       
    }
}