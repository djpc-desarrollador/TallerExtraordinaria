using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taller_Extraordinaria.Datos;

namespace Software
{
   public class NPagoReserva
    {
        private PolancoFinalEntities controlPagoReserva = new PolancoFinalEntities();


        public bool RegistrarPago(PagoReserva entidad)
        {
            {
                bool bresult = false;
                try
                {
                    this.controlPagoReserva.PagoReserva.Add(entidad);
                    this.controlPagoReserva.SaveChanges();
                    bresult = true;
                }
                catch (Exception exception)
                {
                    throw exception;

                }

                return bresult;

            }
        }
        public PagoReserva DevolverPagoReserva(int codigo)
        {
            PagoReserva pagoRes = new PagoReserva();
            try
            {               
                pagoRes = this.controlPagoReserva.PagoReserva.Where(c => c.Id == codigo).FirstOrDefault();             
            }
            catch(Exception)
            { 
            }
            return pagoRes;
        }
    }
}
