//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Acceso
{
    using System;
    using System.Collections.Generic;
    
    public partial class ROL
    {
        public ROL()
        {
            this.PERMISO = new HashSet<PERMISO>();
            this.USUARIO = new HashSet<USUARIO>();
        }
    
        public int IDROL { get; set; }
        public string NOMBRE { get; set; }
    
        public virtual ICollection<PERMISO> PERMISO { get; set; }
        public virtual ICollection<USUARIO> USUARIO { get; set; }
    }
}
