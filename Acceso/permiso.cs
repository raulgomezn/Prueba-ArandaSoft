//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Acceso
{
    using System;
    using System.Collections.Generic;
    
    public partial class permiso
    {
        public int idPermiso { get; set; }
        public string Nombre { get; set; }
        public bool Habilitado { get; set; }
        public int Rol_idRol { get; set; }
    
        public virtual rol rol { get; set; }
    }
}
