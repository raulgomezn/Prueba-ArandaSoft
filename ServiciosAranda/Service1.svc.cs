using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using ArandaLogica;
using ArandaLogica.Modelo;
using System.ServiceModel.Activation;

namespace ServiciosAranda
{
    //[AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class Service1 : IService1
    {
        public string CrearUsuario(int value)
        {
            return string.Format("You entered: {0}", value);
        }
        public string CrearRol(int value)
        {
            return string.Format("You entered: {0}", value);
        }
        public string CrearPermiso(int value)
        {
            return string.Format("You entered: {0}", value);
        }
        public string ListarUsuariosPorRol(int value)
        {
            return string.Format("You entered: {0}", value);
        }
        public string ListarUsuariosPorPermiso(int value)
        {
            return string.Format("You entered: {0}", value);
        }
        //// Listar Roles y Permisos existentes
        public List<Permiso> ListarPermisos()
        {
            LogicaGeneral et = new LogicaGeneral();
            List<Permiso> conditions = et.ListarPermisos();
            return conditions;
        }
        public string ListarRoles()
        {
            return string.Format("You entered:");
        }



        ///----
        public string GetData(string value)
        {
            return string.Format("You entered: {0}", Convert.ToInt32(value));
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
    }
}
