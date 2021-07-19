using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using WcfServicioTarjetasULACIT.Models;

namespace WcfServicioTarjetasULACIT
{
     public class ServicioTarjetas : ITarjetas
    {

        public IEnumerable<Emisor> ConsultarEmisores()
        {
            using(TARJETAS_SW_ULACITEntities modelo = new TARJETAS_SW_ULACITEntities())
            {
                return modelo.Emisor.ToList();
            }
        }

        public IEnumerable<Emisor> ConsultarEmisoresPorDescripcion(string descripcion)
        {
            using(TARJETAS_SW_ULACITEntities modelo = new TARJETAS_SW_ULACITEntities())
            {
                return modelo.Emisor.Where(e => e.EMI_DESCRIPCION.Equals(descripcion)).ToList();
            }
        }

        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
    }
}
