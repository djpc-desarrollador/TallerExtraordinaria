using Software.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taller_Extraordinaria.Datos;

namespace Software
{
    class NDeporte
    {
        private PolancoFinalEntities Conexion;

        public NDeporte()
        {
            this.Conexion = ConexionSQL.GetInstance().Conexion;
        }

        public bool Actualizar(Deporte entidad)
        {
            try
            {
                Deporte original = this.Conexion.Deporte.Find(entidad.Codigo);
                if (original != null)
                {
                    original.Descripcion = entidad.Descripcion;
                }
                this.Conexion.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Deporte> Buscar(Deporte entidad)
        {
            var resultado = this.Conexion.Deporte.Where(a => a.Eliminado == false);
            if (entidad.Codigo > 0)
            {
                resultado.Where(a => a.Codigo == entidad.Codigo);
            }
            if (!string.IsNullOrEmpty(entidad.Descripcion))
            {
                resultado.Where(a => a.Descripcion.Contains(entidad.Descripcion));
            }
            return resultado.ToList();
        }

        public bool Eliminar(Deporte entidad)
        {
            try
            {
                Conexion.Deporte.Find(entidad.Codigo).Eliminado = true;
                Conexion.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool Insertar(Deporte entidad)
        {
            try
            {
                Conexion.Deporte.Add(entidad);
                Conexion.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Deporte> ListarTodos()
        {
            return Conexion.Deporte.Where(a => a.Eliminado == false).ToList();
        }

        public Int32 SiguienteCodigo()
        {
            var lista = this.Conexion.Deporte.ToList();
            if (lista == null || lista.Count == 0)
            {
                return 1;
            }
            return lista.Last<Deporte>().Codigo + 1;
        }
    }
}
