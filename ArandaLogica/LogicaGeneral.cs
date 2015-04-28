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
    #endregion

    public class LogicaGeneral
    {
        /// <summary>
        /// Listar Permisos.
        /// </summary>
        /// <returns>Retorna la lista de los permisos con nombre y llave.</returns>
        public IList<String> ListarPermisos() 
        { 
             
            dbarandaEntities context = new dbarandaEntities();
            
                    List<string> conditions = new List<string>();

                    var query = from es in context.permiso.AsNoTracking()
                                select new { es.idPermiso, es.Nombre };
                    query = query.Distinct();
            return conditions;
        }
    }
}
