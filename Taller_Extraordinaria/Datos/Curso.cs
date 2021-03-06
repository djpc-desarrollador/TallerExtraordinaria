//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Taller_Extraordinaria.Datos
{
    using System;
    using System.Collections.Generic;
    
    public partial class Curso
    {
        public Curso()
        {
            this.PagoCurso = new HashSet<PagoCurso>();
        }
    
        public int Codigo { get; set; }
        public int IdDeporte { get; set; }
        public int IdProfesor { get; set; }
        public string NombreCurso { get; set; }
        public decimal Costo { get; set; }
        public string Observacion { get; set; }
        public Nullable<int> Duracion { get; set; }
        public System.DateTime FechaInicio { get; set; }
        public System.DateTime FechaFin { get; set; }
        public System.TimeSpan HoraInicio { get; set; }
        public System.TimeSpan HoraFin { get; set; }
        public bool Eliminado { get; set; }
    
        public virtual Deporte Deporte { get; set; }
        public virtual Profesor Profesor { get; set; }
        public virtual ICollection<PagoCurso> PagoCurso { get; set; }
    }
}
