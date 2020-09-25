using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web_App_Unit_7
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        //./IT391_Unit7/students.xml
        {
            studentGrades sg = new studentGrades("./IT391_Unit7/students2.xml");
            txtAverageGrade.Text = sg.AvgGrade.ToString();
            txtHighestGrade.Text = sg.MaxGrade.ToString();
            txtLowestGrade.Text = sg.MinGrade.ToString();    
        }
    }
}