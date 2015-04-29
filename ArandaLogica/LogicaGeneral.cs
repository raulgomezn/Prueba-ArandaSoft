// ----------------------------------------------------------------------
// <copyright file="LogicaGeneral.cs" company="Personal">
// Todos los derechos reservados.
// Autor: Raul Gomez
// Fecha: Abril 2015
// </copyright>
// <summary>Clase LogicaGeneral.</summary>
// ----------------------------------------------------------------------

namespace ArandaLogica
{
    #region
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Acceso;
    using ArandaLogica.Modelo;
    #endregion

    public class LogicaGeneral
    {
        /// <summary>
        /// Listar Permisos.
        /// </summary>
        /// <returns>Retorna la lista de los permisos con nombre.</returns>
        public List<Permiso> ListarPermisos()
        {
            DBARANDAEntities context = new DBARANDAEntities();

            var query = (from es in context.PERMISO.AsNoTracking()
                        select new Permiso { nombre = es.NOMBRE }).Distinct();

            return query.ToList();
        }

        /// <summary>
        /// Listar Roles.
        /// </summary>
        /// <returns>Retorna la lista de los roles con nombre.</returns>
        public List<Permiso> ListarRoles()
        {
            DBARANDAEntities context = new DBARANDAEntities();

            var query = (from es in context.ROL.AsNoTracking()
                         select new Permiso { nombre = es.NOMBRE }).Distinct();

            return query.ToList();
        }

        /// <summary>
        /// Listar Por Rol
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public List<Permiso> ListarPorRol(string value)
        {
            DBARANDAEntities context = new DBARANDAEntities();

            var query = (from us in context.USUARIO.AsNoTracking()
                         join es in context.ROL.AsNoTracking() on us.IDROL equals es.IDROL
                         where es.NOMBRE.Equals(value)
                         select new Permiso { nombre = us.NOMBRE }).Distinct();

            return query.ToList();
        }

        /// <summary>
        /// Listar Por Permiso.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public List<Permiso> ListarPorPermiso(string value)
        {
            DBARANDAEntities context = new DBARANDAEntities();

            var query = (from us in context.USUARIO.AsNoTracking()
                         join es in context.ROL.AsNoTracking() on us.IDROL equals es.IDROL
                         join per in context.PERMISO.AsNoTracking() on es.IDROL equals per.IDROL
                         where per.NOMBRE.Equals(value)
                         select new Permiso { nombre = us.NOMBRE });//.Distinct();

            return query.ToList();
        }
        
    }
}
