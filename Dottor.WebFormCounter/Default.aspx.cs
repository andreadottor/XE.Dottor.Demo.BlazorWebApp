namespace Dottor.WebFormCounter
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.UI;
    using System.Web.UI.WebControls;

    public partial class _Default : Page
    {

        public int CounterValue
        {
            get
            {
                if (ViewState["CounterValue"] != null)
                    return (int)ViewState["CounterValue"];
                else
                    return 0;
            }
            set
            {
                ViewState["CounterValue"] = value;
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
                lblCounter.Text = CounterValue.ToString();
        }

        protected void btnIncrement_Click(object sender, EventArgs e)
        {
            CounterValue++;
            lblCounter.Text = CounterValue.ToString();
        }

        protected void btnDecrement_Click(object sender, EventArgs e)
        {
            CounterValue--;
            lblCounter.Text = CounterValue.ToString();
        }
    }
}