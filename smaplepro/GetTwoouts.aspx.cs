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
            try
            {
                var n1 = Convert.ToInt32(txtInputOne.Text);
                var n2 = Convert.ToInt32(txtInputTwo.Text);

                if (n1 > 0 && n2 > 0)
                {
                    // twoway two = new twoway();

                    //var res= ShowResult(n1, n2);
                    // lblInteger.Text = res.SumValue.ToString();
                    // lblstring.Text = res.MultilplicationIs;
                    var resTup = MultiReqturn(n1, n2);
                    lblInteger.Text = resTup.Item1.ToString();
                    lblstring.Text = resTup.Item2.ToString();
                }
                else
                {
                    lblstring.Text = "Please enter numbers greater then Zero";
                }
            }
            catch(Exception Ex)
            {
                Console.WriteLine(Ex.Message);
            }

        }
        public twoway ShowResult(int a,int b)

        {
            var tw= new twoway();
            tw.SumValue = a + b;
            tw.MultilplicationIs = "Multiplication is " + a * b;


            return tw;

        }


        public Tuple<int, string> MultiReqturn(int a, int b)
        {
            int sum = a + b;
            string mul = "Multiplicatio is " + (a * b);

            return Tuple.Create(sum, mul);
        }

    }

   
}