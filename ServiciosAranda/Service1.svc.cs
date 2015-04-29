namespace ServiciosAranda
{
    #region
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
    #endregion
    public class Service1 : IService1
    {
        /// <summary>
        /// Listar Usuarios Por Rol.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public List<Permiso> ListarUsuariosPorRol(string value)
        {
            LogicaGeneral et = new LogicaGeneral();
            List<Permiso> conditions = et.ListarPorRol(value);
            return conditions;
        }

        /// <summary>
        /// Listar Usuarios Por Permiso.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public List<Permiso> ListarUsuariosPorPermiso(string value)
        {
            LogicaGeneral et = new LogicaGeneral();
            List<Permiso> conditions = et.ListarPorPermiso(value);
            return conditions;
        }
        //// Listar Roles y Permisos existentes

        /// <summary>
        /// Listar Permisos.
        /// </summary>
        /// <returns>Lista de permisos en formato JSON.</returns>
        public List<Permiso> ListarPermisos()
        {
            LogicaGeneral et = new LogicaGeneral();
            List<Permiso> conditions = et.ListarPermisos();
            return conditions;
        }
        /// <summary>
        /// Listar Roles.
        /// </summary>
        /// <returns></returns>
        public List<Permiso> ListarRoles()
        {
            LogicaGeneral et = new LogicaGeneral();
            List<Permiso> conditions = et.ListarRoles();
            return conditions;
        }

        //TODO
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


        ////----
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
