using Datos.Contratos;
using Datos.Modelo;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class UsuarioDatos : IUsuarioDatos
    {
      
        public void InsertUsuario(Usuario oUsuario) {
            using (DigitalBankEntities ctx = new DigitalBankEntities())
            {
                ctx.SpUsuario(1, oUsuario.Nombre, oUsuario.FechaNacimiento, oUsuario.Sexo, (int)Opciones.INSERT);
            }
        }

        public void DeleteUsuario(Usuario oUsuario)
        {
            using (DigitalBankEntities ctx = new DigitalBankEntities())
            {
                ctx.SpUsuario(oUsuario.Id, oUsuario.Nombre, oUsuario.FechaNacimiento, oUsuario.Sexo, (int)Opciones.DELETE);
            }
        }

        public void UpdateUsuario(Usuario oUsuario)
        {
            using (DigitalBankEntities ctx = new DigitalBankEntities())
            {
                ctx.SpUsuario(oUsuario.Id, oUsuario.Nombre, oUsuario.FechaNacimiento, oUsuario.Sexo, (int)Opciones.UPDATE);
            }
        }

        public List<Usuario> SelectUsuario()
        {
            List<Usuario> oListUsuario = new List<Usuario>();
            using (DigitalBankEntities ctx = new DigitalBankEntities())
            {
                var salida = ctx.SpUsuario(0, String.Empty, DateTime.Now, String.Empty, (int)Opciones.SELECT).ToList();
                foreach (var item in salida)
                {
                    oListUsuario.Add(new Usuario
                    {
                        FechaNacimiento = item.FechaNacimiento,
                        Id = item.Id,
                        Nombre = item.Nombre,
                        Sexo = item.Sexo
                    });
                }
            }
            return oListUsuario;
        }
    }
}
