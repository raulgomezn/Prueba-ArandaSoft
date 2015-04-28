using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using ArandaLogica;

namespace ServiciosAranda
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
    // NOTE: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class Service1 : IService1
    {
        /*
         * crear usuarios, roles, permisos
         * listar los usuarios por un rol determinado y por un permiso determinado.
         * */
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
        public string ListarPermisos()
        {
            LogicaGeneral et = new LogicaGeneral();
            IList<string> conditions = et.ListarPermisos();
            return string.Format("You entered: ListarPermisos");
        }
        public string ListarRoles()
        {
            return string.Format("You entered:");
        }



        ///----
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
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
