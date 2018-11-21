using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using smaplepro.BAL;


namespace smaplepro
{
    public partial class GetDay : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGetDay_Click(object sender, EventArgs e)
        {
            try
            {
                int days = Convert.ToInt32(txtDays.Text);
                if (days > 0)
                {
                    DateTime requestDate = DateTime.UtcNow.AddDays(days);
                    var reqDay = requestDate.DayOfWeek;
                    
                    naadate obj = new naadate(reqDay.ToString());

                    errorMsg.Text = obj.UserMessage;

                }
                else
                {
                    errorMsg.Text = "Please enter number greter then 0";
                }
            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.Message);
            }
            finally
            {

            }

        }

        protected void btnPastDay_Click(object sender, EventArgs e)
        {
            try
            {
                int days = Convert.ToInt32(txtDays.Text);
                if (days > 0)
                {
                    DateTime requestDate = DateTime.UtcNow.AddDays(-days);
                    var reqDay = requestDate.DayOfWeek;

                    naadate obj = new naadate(reqDay.ToString());

                    errorMsg.Text = obj.UserMessage;

                }
                else
                {
                    errorMsg.Text = "Please enter number greter then 0";
                }
            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.Message);
            }
            finally
            {

            }
        }

    }
}