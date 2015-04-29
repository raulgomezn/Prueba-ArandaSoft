// ----------------------------------------------------------------------
// <copyright file="Permiso.cs" company="Personal">
// Todos los derechos reservados.
// Autor: Raul Gomez
// Fecha: Abril 2015
// </copyright>
// <summary>Clase Permiso.</summary>
// ----------------------------------------------------------------------

namespace ArandaLogica.Modelo
{
    #region
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    #endregion
    //[Serializable]

    /// <summary>
    /// Clase modelo para permiso y para rol.
    /// </summary>
    public class Permiso
    {
        [JsonProperty(PropertyName = "nombre")]
        public string nombre { get; set; }

    }
}
