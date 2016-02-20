using Software.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taller_Extraordinaria.Datos;

namespace Software
{
    class NegocioProfesor
    {
        private PolancoFinalEntities Conexion;

        public NegocioProfesor()
        {
            this.Conexion = ConexionSQL.GetInstance().Conexion;
        }

        public bool Actualizar(Profesor entidad)
        {
            try
            {
                Profesor original = this.Conexion.Profesor.Find(entidad.Id);
                if (original != null)
                {
                    original.Apellido1 = entidad.Apellido1;
                    original.Apellido2 = entidad.Apellido2;
                    original.Nombres = entidad.Nombres;
                    original.CedulaIdentidad = entidad.CedulaIdentidad;
                    original.Telefono = entidad.Telefono;
                }
                this.Conexion.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Profesor> Buscar(Profesor entidad)
        {
            try
            {
                var resultado = this.Conexion.Profesor.Where(a => a.Eliminado == false);
                if (entidad.Id > 0)
                {
                    resultado = resultado.Where(a => a.Id == entidad.Id);
                }
                if (!string.IsNullOrEmpty(entidad.Apellido1))
                {
                    resultado = resultado.Where(a => a.Apellido1.Contains(entidad.Apellido1));
                }
                if (!string.IsNullOrEmpty(entidad.Apellido2))
                {
                    resultado = resultado.Where(a => a.Apellido2.Contains(entidad.Apellido2));
                }
                if (!string.IsNullOrEmpty(entidad.Nombres))
                {
                    resultado = resultado.Where(a => a.Nombres.Contains(entidad.Nombres));
                }
                if (!string.IsNullOrEmpty(entidad.CedulaIdentidad))
                {
                    resultado = resultado.Where(a => a.CedulaIdentidad.Contains(entidad.CedulaIdentidad));
                }
                if (!string.IsNullOrEmpty(entidad.Telefono))
                {
                    resultado = resultado.Where(a => a.Telefono.Contains(entidad.Telefono));
                }
                return resultado.ToList();
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }

        public bool Eliminar(Profesor entidad)
        {
            try
            {
                Conexion.Profesor.Find(entidad.Id).Eliminado = true;
                Conexion.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool Insertar(Profesor entidad)
        {
            try
            {
                Conexion.Profesor.Add(entidad);
                Conexion.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Profesor> ListarTodos()
        {
            return Conexion.Profesor.Where(a => a.Eliminado == false).ToList();
        }

        public Int32 SiguienteCodigo()
        {
            var lista = this.Conexion.Profesor.ToList();
            if (lista == null || lista.Count == 0)
            {
                return 1;
            }
            return lista.Last<Profesor>().Id + 1;
        }
    }
}
