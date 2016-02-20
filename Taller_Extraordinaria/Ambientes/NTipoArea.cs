using Software.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taller_Extraordinaria.Datos;

namespace Software
{
    class NTipoArea
    {
        private PolancoFinalEntities conexion;
        private string nombreTabla;

        public NTipoArea()
        {
            this.conexion = ConexionSQL.GetInstance().Conexion;
            this.nombreTabla = "TipoArea";
        }

        public bool Eliminar(TipoArea entidad)
        {
            try
            {
                conexion.TipoArea.Find(entidad.Codigo).Eliminado = true;
                conexion.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool Actualizar(TipoArea entidad)
        {
            try
            {
                TipoArea original = conexion.TipoArea.Find(entidad.Codigo);
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

        public bool Insertar(TipoArea entidad)
        {
            try
            {
                conexion.TipoArea.Add(entidad);
                conexion.SaveChanges();
                return true;
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }

        public List<TipoArea> ListarTodos()
        {
            System.Data.Entity.DbSet<TipoArea> d = this.conexion.TipoArea;
            List<TipoArea> l = d.Where(p => p.Eliminado == false).ToList();
            if (l == null)
            {
                return new List<TipoArea>();
            }
            else
            {
                return l;
            }
        }

        public Int32 SiguienteCodigoGenerado()
        {
            List<TipoArea> lista = conexion.TipoArea.ToList();
            if (lista == null || lista.Count == 0)
            {
                return 1;
            }

            TipoArea item = lista.Last();

            if (item == null)
            {
                return 1;
            }
            else
            {
                return item.Codigo + 1;
            }
        }

        public List<TipoArea> Buscar(TipoArea entidad)
        {
            var resultado = this.conexion.TipoArea.Where(a => a.Eliminado == false);
            if (entidad.Codigo > 0)
            {
                resultado = resultado.Where(a => a.Codigo == entidad.Codigo);
            }
            if (!string.IsNullOrEmpty(entidad.Descripcion))
            {
                resultado = resultado.Where(a=>a.Descripcion.Contains(entidad.Descripcion));
            }
            return resultado.ToList();
        }
    }
}
