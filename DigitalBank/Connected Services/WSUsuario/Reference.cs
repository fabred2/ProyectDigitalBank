﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DigitalBank.WSUsuario {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WSUsuario.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/InsertUsuario", ReplyAction="http://tempuri.org/IService1/InsertUsuarioResponse")]
        void InsertUsuario(Entidades.Usuario oUsuario);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/InsertUsuario", ReplyAction="http://tempuri.org/IService1/InsertUsuarioResponse")]
        System.Threading.Tasks.Task InsertUsuarioAsync(Entidades.Usuario oUsuario);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SelectUsuario", ReplyAction="http://tempuri.org/IService1/SelectUsuarioResponse")]
        Entidades.Usuario[] SelectUsuario();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SelectUsuario", ReplyAction="http://tempuri.org/IService1/SelectUsuarioResponse")]
        System.Threading.Tasks.Task<Entidades.Usuario[]> SelectUsuarioAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SelectUsuarioById", ReplyAction="http://tempuri.org/IService1/SelectUsuarioByIdResponse")]
        Entidades.Usuario SelectUsuarioById(int Id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SelectUsuarioById", ReplyAction="http://tempuri.org/IService1/SelectUsuarioByIdResponse")]
        System.Threading.Tasks.Task<Entidades.Usuario> SelectUsuarioByIdAsync(int Id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteUsuario", ReplyAction="http://tempuri.org/IService1/DeleteUsuarioResponse")]
        void DeleteUsuario(Entidades.Usuario oUsuario);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteUsuario", ReplyAction="http://tempuri.org/IService1/DeleteUsuarioResponse")]
        System.Threading.Tasks.Task DeleteUsuarioAsync(Entidades.Usuario oUsuario);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/UpdateUsuario", ReplyAction="http://tempuri.org/IService1/UpdateUsuarioResponse")]
        void UpdateUsuario(Entidades.Usuario oUsuario);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/UpdateUsuario", ReplyAction="http://tempuri.org/IService1/UpdateUsuarioResponse")]
        System.Threading.Tasks.Task UpdateUsuarioAsync(Entidades.Usuario oUsuario);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : DigitalBank.WSUsuario.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<DigitalBank.WSUsuario.IService1>, DigitalBank.WSUsuario.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void InsertUsuario(Entidades.Usuario oUsuario) {
            base.Channel.InsertUsuario(oUsuario);
        }
        
        public System.Threading.Tasks.Task InsertUsuarioAsync(Entidades.Usuario oUsuario) {
            return base.Channel.InsertUsuarioAsync(oUsuario);
        }
        
        public Entidades.Usuario[] SelectUsuario() {
            return base.Channel.SelectUsuario();
        }
        
        public System.Threading.Tasks.Task<Entidades.Usuario[]> SelectUsuarioAsync() {
            return base.Channel.SelectUsuarioAsync();
        }
        
        public Entidades.Usuario SelectUsuarioById(int Id) {
            return base.Channel.SelectUsuarioById(Id);
        }
        
        public System.Threading.Tasks.Task<Entidades.Usuario> SelectUsuarioByIdAsync(int Id) {
            return base.Channel.SelectUsuarioByIdAsync(Id);
        }
        
        public void DeleteUsuario(Entidades.Usuario oUsuario) {
            base.Channel.DeleteUsuario(oUsuario);
        }
        
        public System.Threading.Tasks.Task DeleteUsuarioAsync(Entidades.Usuario oUsuario) {
            return base.Channel.DeleteUsuarioAsync(oUsuario);
        }
        
        public void UpdateUsuario(Entidades.Usuario oUsuario) {
            base.Channel.UpdateUsuario(oUsuario);
        }
        
        public System.Threading.Tasks.Task UpdateUsuarioAsync(Entidades.Usuario oUsuario) {
            return base.Channel.UpdateUsuarioAsync(oUsuario);
        }
    }
}
