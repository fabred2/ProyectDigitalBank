﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Datos.Modelo
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class DigitalBankEntities : DbContext
    {
        public DigitalBankEntities()
            : base("name=DigitalBankEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
    
        public virtual ObjectResult<SpUsuario_Result> SpUsuario(Nullable<int> id, string nombre, Nullable<System.DateTime> fechaNacimiento, string sexo, Nullable<int> tipoConsulta)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("Id", id) :
                new ObjectParameter("Id", typeof(int));
    
            var nombreParameter = nombre != null ?
                new ObjectParameter("nombre", nombre) :
                new ObjectParameter("nombre", typeof(string));
    
            var fechaNacimientoParameter = fechaNacimiento.HasValue ?
                new ObjectParameter("FechaNacimiento", fechaNacimiento) :
                new ObjectParameter("FechaNacimiento", typeof(System.DateTime));
    
            var sexoParameter = sexo != null ?
                new ObjectParameter("Sexo", sexo) :
                new ObjectParameter("Sexo", typeof(string));
    
            var tipoConsultaParameter = tipoConsulta.HasValue ?
                new ObjectParameter("TipoConsulta", tipoConsulta) :
                new ObjectParameter("TipoConsulta", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SpUsuario_Result>("SpUsuario", idParameter, nombreParameter, fechaNacimientoParameter, sexoParameter, tipoConsultaParameter);
        }
    }
}