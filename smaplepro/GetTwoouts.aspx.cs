using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using smaplepro.BAL;

namespace smaplepro
{
    public partial class GetTwoouts : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGet_Click(object sender, EventArgs e)
        {

            var n1 = Convert.ToInt32(txtInputOne.Text);
            var n2 = Convert.ToInt32(txtInputTwo.Text);
            twoway two = new twoway();
           
           var res= ShowResult(n1, n2);
            lblInteger.Text = res.SumValue.ToString();
            lblstring.Text = res.MultilplicationIs;

        }
        public twoway ShowResult(int a,int b)

        {
            var tw= new twoway();
            tw.SumValue = a + b;
            tw.MultilplicationIs = "Multiplication is " + a * b;


            return tw;

        }


    }

   
}