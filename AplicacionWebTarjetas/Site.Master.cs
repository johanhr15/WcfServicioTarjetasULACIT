using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AplicacionWebTarjetas
{
    public partial class SiteMaster : MasterPage
    {
        protected override void OnInit(EventArgs e)
        {
            Response.Cache.SetCacheability(HttpCacheability.NoCache);
            Response.Cache.SetNoStore();
            Response.Cache.SetExpires(DateTime.MinValue);
            base.OnInit(e);
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}