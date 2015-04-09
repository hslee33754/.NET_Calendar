using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    /* This program takes a calendar date and 
     * calculates the days from the current date 
     * Kate Lee 4/9/2015 */

    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        DateTime birthDate = Calendar1.SelectedDate;
        DateTime currentDate = DateTime.Now;

        int days = birthDate.Subtract(currentDate).Days;

        lblResult.Text = "There are " + days.ToString() + " days until your birthday.";
    }
}