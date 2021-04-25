using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RasporedCasova
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Init(object sender, EventArgs e)
        {
            Razred razred = new Razred();
            ddlRazred.DataSource = razred.SviRazredi;
            ddlRazred.DataBind();
            razred.PreuzmiSvePodatke(ddlRazred.SelectedItem.Text);
            ddlSmena.DataSource = razred.SveSmene;
            ddlSmena.DataBind();
        }

        protected void ddlRazred_SelectedIndexChanged(object sender, EventArgs e)
        {

            Razred razred = new Razred();
            razred.PreuzmiSvePodatke(ddlRazred.SelectedItem.Text);
            ddlSmena.DataSource = razred.SveSmene;
            ddlSmena.DataBind();
        }

        protected void btnPrikazi_Click(object sender, EventArgs e)
        {
            Razred razred = new Razred(ddlRazred.SelectedItem.Text);
            if (ddlSmena.SelectedIndex == 0)
            {
                GridView1.DataSource = razred.PredmetiA;
            }
            else 
            {
                GridView1.DataSource = razred.PredmetiB;
            }
            GridView1.DataBind();
        }
    }
}
