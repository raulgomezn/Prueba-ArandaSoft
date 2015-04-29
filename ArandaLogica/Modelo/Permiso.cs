using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace ArandaLogica.Modelo
{
    //[Serializable]
    public class Permiso
    {
        [JsonProperty(PropertyName = "nombre")]
        public string nombre { get; set; }

    }
}
