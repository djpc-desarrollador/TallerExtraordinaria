using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taller_Extraordinaria.Datos;

namespace Software
{
    class NArea
    {
        private PolancoFinalEntities conexion;

        public NArea()
        {
            this.conexion = Datos.ConexionSQL.GetInstance().Conexion;
        }

        public bool Actualizar(Area entidad)
        {
            try
            {
                Area original = conexion.Area.Find(entidad.Codigo);
                if (original != null)
                {
                    original.Descripcion = entidad.Descripcion;
                    original.IdTipoArea = entidad.IdTipoArea;
                }
                conexion.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Area> Buscar(Area entidad)
        {
            try
            {
                var resultado = conexion.Area.Where(a => a.Eliminado == false);
                if (entidad.Codigo > 0)
                {
                    resultado = resultado.Where(a => a.Codigo == entidad.Codigo);
                }
                if (string.IsNullOrEmpty(entidad.Descripcion))
                {
                    resultado = resultado.Where(a => a.Descripcion.Contains(entidad.Descripcion));
                }
                return resultado.ToList();
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }

        public bool Eliminar(Area entidad)
        {
            try
            {
                conexion.Area.Remove(entidad);
                conexion.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool Insertar(Area entidad)
        {
            try
            {
                conexion.Area.Add(entidad);
                conexion.SaveChanges();
                return true;
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }

        public List<Area> ListarTodos()
        {
            return this.conexion.Area.Where(a=> a.Eliminado == false).ToList();
        }

        public Int32 SiguienteCodigoGenerado()
        {
            List<Area> lista = ListarTodos();
            if (lista == null || lista.Count == 0)
            {
                return 1;
            }

            Area item = lista.Last();

            if (item == null)
            {
                return 1;
            }
            else
            {
                return item.Codigo + 1;
            }
        }
    }
}
