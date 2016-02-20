using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data.Entity;
using System.Data.SqlTypes;
using System.Data;
using Taller_Extraordinaria.Datos;

namespace Software
{
    public class NReserva
    {
        private PolancoFinalEntities controlReserva = new PolancoFinalEntities();


        public bool RegistrarReserva(Reserva entidad)
        {
            {
                bool bresult = false;
                try
                {
                    this.controlReserva.Reserva.Add(entidad);
                    this.controlReserva.SaveChanges();
                    bresult = true;
                }
                catch (Exception exception)
                {
                    throw exception;

                }

                return bresult;

            }
        }

        public List<Reserva> BusquedaReserva(string codreserva, string fecha, string nombre, string apellido1, string apellido2, string cedula)
        {

            var reserva = controlReserva.Reserva.SqlQuery("Select * from Reserva where Codigo like '" + "%" + codreserva + "%" + "'and Fecha ='" + fecha + "'and Nombre like '" + "%" + nombre + "%" + "' and Apellido1 like'" + "%" + apellido1 + "%" + "'and Apellido2 like '" + "%" + apellido2 + "%" + "'and CedulaIdentidad like '" + "%" + cedula + "%" + "'").ToList();
            return reserva;
        }

        public Reserva DevolverReserva(int cod)
        {
            Reserva reserva = new Reserva();
            try
            {
                reserva = this.controlReserva.Reserva.Where(c => c.Codigo == cod).FirstOrDefault();
                return reserva;
            }
            catch (Exception)
            {
            }
            return reserva;
        }

        public bool ModificarReserva(Reserva updateReserva)
        {
            bool bresult = false;
            try
            {
                this.controlReserva.Reserva.Attach(updateReserva);
                this.controlReserva.Entry(updateReserva).State = EntityState.Modified;
                this.controlReserva.SaveChanges();
                bresult = true;
            }
            catch (Exception exception)
            {
                throw exception;
            }

            return bresult;
        }

        public List<Reserva> ListarTodo()
        {
            return this.controlReserva.Reserva.Where(a => a.Eliminado == false).ToList();
        }

        public int SiguienteReserva()
        {
            int result = 0;
            try
            {
                using (PolancoFinalEntities reservaEntity = new PolancoFinalEntities())
                {
                    var query =
                        (from reserva in reservaEntity.Reserva
                         orderby reserva.Codigo descending
                         select new
                         {
                             aId = reserva.Codigo,


                         }).FirstOrDefault();

                    if (query == null)
                    {
                        result = result + 1;
                    }
                    else
                    {
                        result = query.aId + 1;
                    }
                }
            }
            catch (Exception)
            {
            }
            return result;
        }

        public List<Reserva> VerificarValidezDeLaReserva(Reserva reserva)
        {
            var coincidencias = this.controlReserva.Reserva.Where(a => a.Eliminado == false);
            coincidencias = coincidencias.Where(a => a.CodigoArea == reserva.CodigoArea);
            coincidencias = coincidencias.Where(a => a.Fecha == reserva.Fecha.Value);


            var b = coincidencias.Where(a => reserva.HoraInicio < a.HoraInicio && reserva.HoraFin > a.HoraFin);
            var c = coincidencias.Where(a => reserva.HoraInicio >= a.HoraInicio && reserva.HoraFin <= a.HoraFin);
            var d = coincidencias.Where(a => reserva.HoraInicio >= a.HoraInicio && reserva.HoraFin > a.HoraFin);
            d = d.Where(a => reserva.HoraInicio < a.HoraFin);
            var e = coincidencias.Where(a => reserva.HoraFin <= a.HoraFin && reserva.HoraInicio < a.HoraInicio);
            e = e.Where(a => reserva.HoraFin > a.HoraInicio);

            var g = b.ToList();
            var h = c.ToList();
            var i = d.ToList();
            var j = e.ToList();

            h.AddRange(g);
            i.AddRange(h);
            j.AddRange(i);

            j = j.Distinct().ToList();

            //return (coincidencias.ToList().Count == 0) ? null : coincidencias.ToList
            return j.ToList();
        }
    }

}
