using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AplicacionWebTarjetas.Views
{
    public partial class frmConsultarEmisoresPorNumeroTarjeta : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnConsultar_Click(object sender, EventArgs e)
        {
            using (ServicioTarjetas.TarjetasClient cliente = new ServicioTarjetas.TarjetasClient())
            {
                if (string.IsNullOrEmpty(txtBusqueda.Text))
                {
                    gvEmisores.DataSource = cliente.ConsultarEmisores();
                    gvEmisores.DataBind();
                }
                else
                {
                    gvEmisores.DataSource = cliente.ConsultarEmisorPorNumeroTarjeta(txtBusqueda.Text);
                    gvEmisores.DataBind();
                }
            }
        }
    }
}