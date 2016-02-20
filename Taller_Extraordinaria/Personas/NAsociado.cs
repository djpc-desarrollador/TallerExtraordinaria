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
  public  class NAsociado
    {
        private PolancoFinalEntities controlAsociado = new PolancoFinalEntities();

        /// <summary>
        /// Esta funcion permite registrar usuarios y devuelve "true" si el usuario fue insertardo correctamente
        /// </summary>
        // REGISTRAR ASOCIADO
        public bool RegistrarAsociado(Asociado asociado)
        {
            bool bresult = false;
            try
            {
                this.controlAsociado.Asociado.Add(asociado);
                this.controlAsociado.SaveChanges();
                bresult = true;
            }
            catch (Exception exception)
            {
                throw exception;

            }

            return bresult;
        }

        // LISTAR ASOCIADOS
        public List<Asociado> ListarAsociado()
        {
            List<Asociado> listaMostrar = new List<Asociado>();
            listaMostrar = this.controlAsociado.Asociado.Where(i => i.Id > 0).ToList();
            return listaMostrar;
        }

        // DEVOLVER ASOCIADO SELECCIONADO
        public Asociado DevolverAsociado(int codigo)
        {
            Asociado asociado = new Asociado();
            asociado = this.controlAsociado.Asociado.Where(c => c.Id == codigo).FirstOrDefault();
            return asociado;
        }

        // MODIFICAR ASOCIADO
        public bool ModificarAsociado(Asociado updateAsociado)
        {
            bool bresult = false;
            try
            {
                this.controlAsociado.Asociado.Attach(updateAsociado);
                this.controlAsociado.Entry(updateAsociado).State = EntityState.Modified;
                this.controlAsociado.SaveChanges();
                bresult = true;
            }
            catch (Exception exception)
            {
                throw exception;
            }

            return bresult;
        }
      // BUSCAR PARAMETRIZADO

        public List<Asociado> BuscarAsociado(string nombre, string apellido1, string apellido2, string codigo, string cedula) 
        {
            var asociado = controlAsociado.Asociado.SqlQuery("Select * from Asociado where Nombre like '" + "%" + nombre + "%" + "'and Apellido1 like'" + "%" + apellido1 + "%" + "'and Apellido2 like '" + "%" + apellido2 + "%" + "' and Codigo like'" + "%" + codigo + "%" + "'and CedulaIdentidad like '" + "%" + cedula + "%" + "' and Id > 0").ToList();
          return asociado;       
        }

        public Asociado BuscarInformacionBasica(int codigo , string cedula) 
        {
            Asociado result = new Asociado();
            using (PolancoFinalEntities context = new PolancoFinalEntities())
            {
                var query =
                    from asociado in context.Asociado
                    where asociado.Codigo == codigo || asociado.CedulaIdentidad == cedula
                    select new
                    {
                        aId =  asociado.Id,
                        aNombre = asociado.Nombre,
                        aApellido1 = asociado.Apellido1,
                        aApellido2 = asociado.Apellido2,
                        aCodigo = asociado.Codigo,
                        aCedula = asociado.CedulaIdentidad
                        
                    };
                foreach (var asociado in query)
                {
                    result.Id = asociado.aId;
                    result.Nombre = asociado.aNombre;
                    result.Apellido1 = asociado.aApellido1;
                    result.Apellido2 = asociado.aApellido2;
                    result.Codigo = asociado.aCodigo;
                    result.CedulaIdentidad = asociado.aCedula;
                }
            }
            return result;
        }

    }
}
