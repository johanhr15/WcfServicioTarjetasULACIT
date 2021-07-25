using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AplicacionWebTarjetas.Views
{
    public partial class frmConsultarTarjetaValidez : System.Web.UI.Page
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
                    lblEstado.Text = "Numero de Tarjeta Invalido";
                }
                else
                {
                    lblEstado.Text = cliente.ConsultarValidezTarjeta(txtBusqueda.Text);
                }
            }
        }
    }
}