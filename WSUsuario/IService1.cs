using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WSUsuario
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        void InsertUsuario(Usuario oUsuario);

        [OperationContract]
        List<Usuario> SelectUsuario();

         [OperationContract]
        void DeleteUsuario(Usuario oUsuario);

        [OperationContract]
        void UpdateUsuario(Usuario oUsuario);
        // TODO: agregue aquí sus operaciones de servicio
    }
  
}
