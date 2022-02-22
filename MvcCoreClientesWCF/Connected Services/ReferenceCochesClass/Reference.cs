﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ReferenceCochesClass
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Coche", Namespace="http://schemas.datacontract.org/2004/07/ServiceWCFLogicaCoches.Models")]
    public partial class Coche : object
    {
        
        private int IdCocheField;
        
        private string ImagenField;
        
        private string MarcaField;
        
        private string ModeloField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int IdCoche
        {
            get
            {
                return this.IdCocheField;
            }
            set
            {
                this.IdCocheField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Imagen
        {
            get
            {
                return this.ImagenField;
            }
            set
            {
                this.ImagenField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Marca
        {
            get
            {
                return this.MarcaField;
            }
            set
            {
                this.MarcaField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Modelo
        {
            get
            {
                return this.ModeloField;
            }
            set
            {
                this.ModeloField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ReferenceCochesClass.ICochesContract")]
    public interface ICochesContract
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICochesContract/GetCoches", ReplyAction="http://tempuri.org/ICochesContract/GetCochesResponse")]
        System.Threading.Tasks.Task<ReferenceCochesClass.Coche[]> GetCochesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICochesContract/FindCoche", ReplyAction="http://tempuri.org/ICochesContract/FindCocheResponse")]
        System.Threading.Tasks.Task<ReferenceCochesClass.Coche> FindCocheAsync(int id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    public interface ICochesContractChannel : ReferenceCochesClass.ICochesContract, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    public partial class CochesContractClient : System.ServiceModel.ClientBase<ReferenceCochesClass.ICochesContract>, ReferenceCochesClass.ICochesContract
    {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public CochesContractClient() : 
                base(CochesContractClient.GetDefaultBinding(), CochesContractClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.BasicHttpBinding_ICochesContract.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public CochesContractClient(EndpointConfiguration endpointConfiguration) : 
                base(CochesContractClient.GetBindingForEndpoint(endpointConfiguration), CochesContractClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public CochesContractClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(CochesContractClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public CochesContractClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(CochesContractClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public CochesContractClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public System.Threading.Tasks.Task<ReferenceCochesClass.Coche[]> GetCochesAsync()
        {
            return base.Channel.GetCochesAsync();
        }
        
        public System.Threading.Tasks.Task<ReferenceCochesClass.Coche> FindCocheAsync(int id)
        {
            return base.Channel.FindCocheAsync(id);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_ICochesContract))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_ICochesContract))
            {
                return new System.ServiceModel.EndpointAddress("http://localhost:30784/ServiceCoches.svc");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return CochesContractClient.GetBindingForEndpoint(EndpointConfiguration.BasicHttpBinding_ICochesContract);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return CochesContractClient.GetEndpointAddress(EndpointConfiguration.BasicHttpBinding_ICochesContract);
        }
        
        public enum EndpointConfiguration
        {
            
            BasicHttpBinding_ICochesContract,
        }
    }
}
