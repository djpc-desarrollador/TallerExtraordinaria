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
    
    public partial class TipoAsociado
    {
        public TipoAsociado()
        {
            this.Asociado = new HashSet<Asociado>();
        }
    
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public bool Eliminado { get; set; }
    
        public virtual ICollection<Asociado> Asociado { get; set; }
    }
}
