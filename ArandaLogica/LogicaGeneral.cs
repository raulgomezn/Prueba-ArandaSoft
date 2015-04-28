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
        /// <returns>Retorna la lista de los permisos con nombre y llave.</returns>
        public List<Permiso> ListarPermisos()
        {

            DBARANDAEntities context = new DBARANDAEntities();

            List<Permiso> conditions = new List<Permiso>();

            var query = (from es in context.PERMISO.AsNoTracking()
                        select new Permiso { nombre = es.NOMBRE }).Distinct();

            return query.ToList();
        }

        public List<String> ListarRoles()
        {

            DBARANDAEntities context = new DBARANDAEntities();

            List<string> conditions = new List<string>();

            var query = from es in context.PERMISO.AsNoTracking()
                        select new { es.NOMBRE };
            query = query.Distinct();
            return conditions;
        }
    }
}
