using Software.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taller_Extraordinaria.Datos;

namespace Software
{
    class NCurso
    {
        private PolancoFinalEntities Conexion;

        public NCurso()
        {
            this.Conexion = ConexionSQL.GetInstance().Conexion;
        }

        public bool Actualizar(Curso entidad)
        {
            try
            {
                Curso original = this.Conexion.Curso.Find(entidad.Codigo);
                if (original != null)
                {
                    original.IdDeporte = entidad.IdDeporte;
                    original.IdProfesor = entidad.IdDeporte;
                    original.NombreCurso = entidad.NombreCurso;
                    original.Observacion = entidad.Observacion;
                    original.Duracion = entidad.Duracion;
                    original.FechaInicio = entidad.FechaInicio;
                    original.FechaFin = entidad.FechaFin;
                    original.HoraFin = entidad.HoraFin;
                    original.HoraInicio = entidad.HoraInicio;
                }
                this.Conexion.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Curso> Buscar(Curso entidad)
        {
            var resultado = this.Conexion.Curso.Where(a => a.Eliminado == false);
            if (entidad.Codigo > 0)
            {
                resultado = resultado.Where(a => a.Codigo == entidad.Codigo);
            }
            if (entidad.IdDeporte > 0)
            {
                resultado = resultado.Where(a => a.IdDeporte == entidad.IdDeporte);
            }
            if (entidad.IdProfesor > 0)
            {
                resultado = resultado.Where(a => a.IdProfesor == entidad.IdProfesor);
            }
            if (!string.IsNullOrEmpty(entidad.NombreCurso))
            {
                resultado = resultado.Where(a => a.NombreCurso.Contains(entidad.NombreCurso));
            }
            if (!string.IsNullOrEmpty(entidad.Observacion))
            {
                resultado = resultado.Where(a => a.Observacion.Contains(entidad.Observacion));
            }
            return resultado.ToList();
        }

        public bool Eliminar(Curso entidad)
        {
            try
            {
                this.Conexion.Curso.Find(entidad.Codigo).Eliminado = true;
                this.Conexion.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool Insertar(Curso entidad)
        {
            try
            {
                this.Conexion.Curso.Add(entidad);
                this.Conexion.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Curso> ListarTodos()
        {
            return Conexion.Curso.Where(a => a.Eliminado == false).ToList();
        }

        public Int32 SiguienteCodigo()
        {
            var lista = this.Conexion.Curso.ToList();
            if (lista == null || lista.Count == 0)
            {
                return 1;
            }
            return lista.Last<Curso>().Codigo + 1;
        }
    }
}
