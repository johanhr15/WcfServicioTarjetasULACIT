using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using WcfServicioTarjetasULACIT.Models;

namespace WcfServicioTarjetasULACIT
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class ServicioTarjetas : ITarjetas
    {

        public string ConsultarValidezTarjeta(string numero)
        {
            
            using (TARJETAS_SW_ULACITEntities modelo = new TARJETAS_SW_ULACITEntities())
            {
                string estado = "";
                try
                {
                    var validez = (from p in modelo.Tarjeta where p.TAR_NUMERO == numero select p).FirstOrDefault();
                    if (validez.TAR_ESTADO == "Activa" && validez.TAR_FECHA_VENCIMIENTO >= DateTime.Now )
                    {
                        estado = "Tarjeta Válida";
                        return estado;
                    }
                    else {

                        estado = "Tarjeta Inválida";
                        return estado;
                    }
                }
                catch (Exception)
                {
                    estado = "Tarjeta Inválida";
                    return estado;

                }

            }
        }

        public IEnumerable<Tarjeta> ConsultarInformacionTarjeta(string numero)
        {
            using (TARJETAS_SW_ULACITEntities modelo = new TARJETAS_SW_ULACITEntities())
            {
                return modelo.Tarjeta.Where(e => e.TAR_NUMERO.Equals(numero)).ToList();
               
            }
        }

        public IEnumerable<Emisor> ConsultarEmisores()
        {

            using (TARJETAS_SW_ULACITEntities modelo = new TARJETAS_SW_ULACITEntities())
            {
                return modelo.Emisor.ToList();
            }

        }

        public IEnumerable<Emisor> ConsultarEmisoresPorDescripcion(string descripcion)
        {
            using (TARJETAS_SW_ULACITEntities modelo = new TARJETAS_SW_ULACITEntities())
            {
                return modelo.Emisor.Where(e => e.EMI_DESCRIPCION.Equals(descripcion)).ToList();
            }
        }

        public IEnumerable<Emisor> ConsultarEmisorPorNumeroTarjeta(string numero)
        {

            using (TARJETAS_SW_ULACITEntities modelo = new TARJETAS_SW_ULACITEntities())
            {
                if (numero.StartsWith("34") || numero.StartsWith("37"))
                {
                    return modelo.Emisor.Where(e => e.EMI_DESCRIPCION.Equals("American Express")).ToList();
                }

                if (numero.StartsWith("637") || numero.StartsWith("638") || numero.StartsWith("639"))
                {
                    return modelo.Emisor.Where(e => e.EMI_DESCRIPCION.Equals("InstaPayment")).ToList();
                }

                if (numero.StartsWith("3528") || numero.StartsWith("3589"))
                {
                    return modelo.Emisor.Where(e => e.EMI_DESCRIPCION.Equals("JCB")).ToList();
                }

                if (numero.StartsWith("6304") || numero.StartsWith("6706") || numero.StartsWith("6771") || numero.StartsWith("6709"))
                {
                    return modelo.Emisor.Where(e => e.EMI_DESCRIPCION.Equals("Laser")).ToList();
                }

                if (numero.StartsWith("4"))
                {
                    return modelo.Emisor.Where(e => e.EMI_DESCRIPCION.Equals("VISA")).ToList();
                }

                if (numero.StartsWith("6011") || numero.StartsWith("622") || numero.StartsWith("64"))
                {
                    return modelo.Emisor.Where(e => e.EMI_DESCRIPCION.Equals("Discover Card")).ToList();
                }

                if (numero.StartsWith("4026")|| numero.StartsWith("417500") || numero.StartsWith("4508")||numero.StartsWith("4844")|| numero.StartsWith("4913") || numero.StartsWith("4917"))
                {
                    return modelo.Emisor.Where(e => e.EMI_DESCRIPCION.Equals("VISA Electrom")).ToList();
                }

                if (numero.StartsWith("51") || numero.StartsWith("52") || numero.StartsWith("53") || numero.StartsWith("54") || numero.StartsWith("55"))
                {
                    return modelo.Emisor.Where(e => e.EMI_DESCRIPCION.Equals("MasterCard")).ToList();
                }

                if (numero.StartsWith("38"))
                {
                    return modelo.Emisor.Where(e => e.EMI_DESCRIPCION.Equals("Diners Club International")).ToList();
                }
                if (numero.StartsWith("54"))
                {
                    return modelo.Emisor.Where(e => e.EMI_DESCRIPCION.Equals("Diners Club USA&Canada")).ToList();
                }

                else { return modelo.Emisor.Where(e => e.EMI_DESCRIPCION.Equals("")).ToList(); }

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
