using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Contratos
{
    public interface IUsuarioDatos
    {
        void InsertUsuario(Usuario oUsuario);
        List<Usuario> SelectUsuario();
        void DeleteUsuario(Usuario oUsuario);
        void UpdateUsuario(Usuario oUsuario);
    }
}
