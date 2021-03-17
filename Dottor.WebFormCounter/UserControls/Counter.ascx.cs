namespace Dottor.WebFormCounter.UserControls
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.UI;
    using System.Web.UI.WebControls;

    public partial class Counter : System.Web.UI.UserControl
    {

        public string Title
        {
            get { return ViewState["Title"] as string; }
            set { ViewState["Title"] = value; }
        }

        public int CounterValue
        {
            get
            {
                return ViewState["CounterValue"] != null ? (int)ViewState["CounterValue"] : 0;
            }
            set
            {
                ViewState["CounterValue"] = value;
            }
        }

        public int StartValue
        {
            get
            {
                return ViewState["StartValue"] != null ? (int)ViewState["StartValue"] : 0;
            }
            set
            {
                ViewState["StartValue"] = value;
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CounterValue = StartValue;
                lblCounter.Text = CounterValue.ToString();
            }
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