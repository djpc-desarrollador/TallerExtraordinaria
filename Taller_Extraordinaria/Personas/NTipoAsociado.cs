using Software.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taller_Extraordinaria.Datos;

namespace Software
{
    class NTipoAsociado
    {
        private PolancoFinalEntities conexion;

        public NTipoAsociado()
        {
            this.conexion = ConexionSQL.GetInstance().Conexion;
        }

        public bool Actualizar(TipoAsociado entidad)
        {
            try
            {
                TipoAsociado original = this.conexion.TipoAsociado.Find(entidad.Id);
                if (original != null)
                {
                    original.Descripcion = entidad.Descripcion;
                }
                conexion.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<TipoAsociado> Buscar(TipoAsociado entidad)
        {
            try
            {
                var resultado = this.conexion.TipoAsociado.Where(a => a.Eliminado == false);
                if (entidad.Id > 0)
                {
                    resultado = resultado.Where(a => a.Id == entidad.Id);
                }
                if (!string.IsNullOrEmpty(entidad.Descripcion))
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

        public bool Eliminar(TipoAsociado entidad)
        {
            try
            {
                conexion.TipoAsociado.Find(entidad.Id).Eliminado = true;
                conexion.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool Insertar(TipoAsociado entidad)
        {
            try
            {
                conexion.TipoAsociado.Add(entidad);
                conexion.SaveChanges();
                return true;
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }

        public List<TipoAsociado> ListarTodos()
        {
            return this.conexion.TipoAsociado.Where(p => p.Eliminado == false).ToList();
        }

        public Int32 SiguienteCodigoGenerado()
        {
            List<TipoAsociado> lista = conexion.TipoAsociado.ToList();
            if (lista == null || lista.Count == 0)
            {
                return 1;
            }

            TipoAsociado item = lista.Last();

            if (item == null)
            {
                return 1;
            }
            else
            {
                return item.Id + 1;
            }
        }
    }
}
