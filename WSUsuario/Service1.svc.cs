using Entidades;
using Datos;
using Datos.Contratos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WSUsuario
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
    // NOTE: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class Service1 : IService1
    {
        public IUsuarioDatos oIUsuarioDatos;
        public void DeleteUsuario(Usuario oUsuario)
        {
            oIUsuarioDatos = new UsuarioDatos();
            oIUsuarioDatos.DeleteUsuario(oUsuario);
        }

        public void InsertUsuario(Usuario oUsuario)
        {
            oIUsuarioDatos = new UsuarioDatos();
            oIUsuarioDatos.InsertUsuario(oUsuario);
        }

        public List<Usuario> SelectUsuario()
        {
            oIUsuarioDatos = new UsuarioDatos();
            return oIUsuarioDatos.SelectUsuario();
        }


        public void UpdateUsuario(Usuario oUsuario)
        {
            oIUsuarioDatos = new UsuarioDatos();
            oIUsuarioDatos.UpdateUsuario(oUsuario);
        }
    }
}
