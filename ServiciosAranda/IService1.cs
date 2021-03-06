﻿namespace ServiciosAranda
{
    #region
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;
    using System.ServiceModel;
    using System.ServiceModel.Web;
    using System.Text;
    using ArandaLogica.Modelo;
    #endregion
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        //[WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.Wrapped, ResponseFormat = WebMessageFormat.Json)]
        [WebGet(UriTemplate = "/ListarPermisos", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        List<Permiso> ListarPermisos();

        [OperationContract]
        [WebGet(UriTemplate = "/ListarRoles", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        List<Permiso> ListarRoles();
        
        [OperationContract]
        [WebGet(UriTemplate = "/ListarUsuariosPorRol/{value}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        List<Permiso> ListarUsuariosPorRol(string value);

        [OperationContract]
        [WebGet(UriTemplate = "/ListarUsuariosPorPermiso/{value}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        List<Permiso> ListarUsuariosPorPermiso(string value);


        //--
        [OperationContract]
        [WebGet(UriTemplate = "/GetData/{value}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        string GetData(string value);

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);

    }


    // Utilice un contrato de datos, como se ilustra en el ejemplo siguiente, para agregar tipos compuestos a las operaciones de servicio.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
