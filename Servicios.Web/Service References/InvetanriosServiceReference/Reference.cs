﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Servicios.Web.InvetanriosServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Inventario", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class Inventario : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private int NumeroInventarioField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescripcionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ColorField;
        
        private decimal PrecioField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int NumeroInventario {
            get {
                return this.NumeroInventarioField;
            }
            set {
                if ((this.NumeroInventarioField.Equals(value) != true)) {
                    this.NumeroInventarioField = value;
                    this.RaisePropertyChanged("NumeroInventario");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string Descripcion {
            get {
                return this.DescripcionField;
            }
            set {
                if ((object.ReferenceEquals(this.DescripcionField, value) != true)) {
                    this.DescripcionField = value;
                    this.RaisePropertyChanged("Descripcion");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string Color {
            get {
                return this.ColorField;
            }
            set {
                if ((object.ReferenceEquals(this.ColorField, value) != true)) {
                    this.ColorField = value;
                    this.RaisePropertyChanged("Color");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=3)]
        public decimal Precio {
            get {
                return this.PrecioField;
            }
            set {
                if ((this.PrecioField.Equals(value) != true)) {
                    this.PrecioField = value;
                    this.RaisePropertyChanged("Precio");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="InvetanriosServiceReference.WebServiceInventarioSoap")]
    public interface WebServiceInventarioSoap {
        
        // CODEGEN: Generating message contract since element name HelloWorldResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        Servicios.Web.InvetanriosServiceReference.HelloWorldResponse HelloWorld(Servicios.Web.InvetanriosServiceReference.HelloWorldRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        System.Threading.Tasks.Task<Servicios.Web.InvetanriosServiceReference.HelloWorldResponse> HelloWorldAsync(Servicios.Web.InvetanriosServiceReference.HelloWorldRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SumaNumeros", ReplyAction="*")]
        int SumaNumeros(int Numero1, int numero2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SumaNumeros", ReplyAction="*")]
        System.Threading.Tasks.Task<int> SumaNumerosAsync(int Numero1, int numero2);
        
        // CODEGEN: Generating message contract since element name ObtenerInventarioResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ObtenerInventario", ReplyAction="*")]
        Servicios.Web.InvetanriosServiceReference.ObtenerInventarioResponse ObtenerInventario(Servicios.Web.InvetanriosServiceReference.ObtenerInventarioRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ObtenerInventario", ReplyAction="*")]
        System.Threading.Tasks.Task<Servicios.Web.InvetanriosServiceReference.ObtenerInventarioResponse> ObtenerInventarioAsync(Servicios.Web.InvetanriosServiceReference.ObtenerInventarioRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorld", Namespace="http://tempuri.org/", Order=0)]
        public Servicios.Web.InvetanriosServiceReference.HelloWorldRequestBody Body;
        
        public HelloWorldRequest() {
        }
        
        public HelloWorldRequest(Servicios.Web.InvetanriosServiceReference.HelloWorldRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class HelloWorldRequestBody {
        
        public HelloWorldRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorldResponse", Namespace="http://tempuri.org/", Order=0)]
        public Servicios.Web.InvetanriosServiceReference.HelloWorldResponseBody Body;
        
        public HelloWorldResponse() {
        }
        
        public HelloWorldResponse(Servicios.Web.InvetanriosServiceReference.HelloWorldResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class HelloWorldResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string HelloWorldResult;
        
        public HelloWorldResponseBody() {
        }
        
        public HelloWorldResponseBody(string HelloWorldResult) {
            this.HelloWorldResult = HelloWorldResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ObtenerInventarioRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ObtenerInventario", Namespace="http://tempuri.org/", Order=0)]
        public Servicios.Web.InvetanriosServiceReference.ObtenerInventarioRequestBody Body;
        
        public ObtenerInventarioRequest() {
        }
        
        public ObtenerInventarioRequest(Servicios.Web.InvetanriosServiceReference.ObtenerInventarioRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class ObtenerInventarioRequestBody {
        
        public ObtenerInventarioRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ObtenerInventarioResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ObtenerInventarioResponse", Namespace="http://tempuri.org/", Order=0)]
        public Servicios.Web.InvetanriosServiceReference.ObtenerInventarioResponseBody Body;
        
        public ObtenerInventarioResponse() {
        }
        
        public ObtenerInventarioResponse(Servicios.Web.InvetanriosServiceReference.ObtenerInventarioResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class ObtenerInventarioResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public Servicios.Web.InvetanriosServiceReference.Inventario[] ObtenerInventarioResult;
        
        public ObtenerInventarioResponseBody() {
        }
        
        public ObtenerInventarioResponseBody(Servicios.Web.InvetanriosServiceReference.Inventario[] ObtenerInventarioResult) {
            this.ObtenerInventarioResult = ObtenerInventarioResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WebServiceInventarioSoapChannel : Servicios.Web.InvetanriosServiceReference.WebServiceInventarioSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebServiceInventarioSoapClient : System.ServiceModel.ClientBase<Servicios.Web.InvetanriosServiceReference.WebServiceInventarioSoap>, Servicios.Web.InvetanriosServiceReference.WebServiceInventarioSoap {
        
        public WebServiceInventarioSoapClient() {
        }
        
        public WebServiceInventarioSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WebServiceInventarioSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebServiceInventarioSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebServiceInventarioSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Servicios.Web.InvetanriosServiceReference.HelloWorldResponse Servicios.Web.InvetanriosServiceReference.WebServiceInventarioSoap.HelloWorld(Servicios.Web.InvetanriosServiceReference.HelloWorldRequest request) {
            return base.Channel.HelloWorld(request);
        }
        
        public string HelloWorld() {
            Servicios.Web.InvetanriosServiceReference.HelloWorldRequest inValue = new Servicios.Web.InvetanriosServiceReference.HelloWorldRequest();
            inValue.Body = new Servicios.Web.InvetanriosServiceReference.HelloWorldRequestBody();
            Servicios.Web.InvetanriosServiceReference.HelloWorldResponse retVal = ((Servicios.Web.InvetanriosServiceReference.WebServiceInventarioSoap)(this)).HelloWorld(inValue);
            return retVal.Body.HelloWorldResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Servicios.Web.InvetanriosServiceReference.HelloWorldResponse> Servicios.Web.InvetanriosServiceReference.WebServiceInventarioSoap.HelloWorldAsync(Servicios.Web.InvetanriosServiceReference.HelloWorldRequest request) {
            return base.Channel.HelloWorldAsync(request);
        }
        
        public System.Threading.Tasks.Task<Servicios.Web.InvetanriosServiceReference.HelloWorldResponse> HelloWorldAsync() {
            Servicios.Web.InvetanriosServiceReference.HelloWorldRequest inValue = new Servicios.Web.InvetanriosServiceReference.HelloWorldRequest();
            inValue.Body = new Servicios.Web.InvetanriosServiceReference.HelloWorldRequestBody();
            return ((Servicios.Web.InvetanriosServiceReference.WebServiceInventarioSoap)(this)).HelloWorldAsync(inValue);
        }
        
        public int SumaNumeros(int Numero1, int numero2) {
            return base.Channel.SumaNumeros(Numero1, numero2);
        }
        
        public System.Threading.Tasks.Task<int> SumaNumerosAsync(int Numero1, int numero2) {
            return base.Channel.SumaNumerosAsync(Numero1, numero2);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Servicios.Web.InvetanriosServiceReference.ObtenerInventarioResponse Servicios.Web.InvetanriosServiceReference.WebServiceInventarioSoap.ObtenerInventario(Servicios.Web.InvetanriosServiceReference.ObtenerInventarioRequest request) {
            return base.Channel.ObtenerInventario(request);
        }
        
        public Servicios.Web.InvetanriosServiceReference.Inventario[] ObtenerInventario() {
            Servicios.Web.InvetanriosServiceReference.ObtenerInventarioRequest inValue = new Servicios.Web.InvetanriosServiceReference.ObtenerInventarioRequest();
            inValue.Body = new Servicios.Web.InvetanriosServiceReference.ObtenerInventarioRequestBody();
            Servicios.Web.InvetanriosServiceReference.ObtenerInventarioResponse retVal = ((Servicios.Web.InvetanriosServiceReference.WebServiceInventarioSoap)(this)).ObtenerInventario(inValue);
            return retVal.Body.ObtenerInventarioResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Servicios.Web.InvetanriosServiceReference.ObtenerInventarioResponse> Servicios.Web.InvetanriosServiceReference.WebServiceInventarioSoap.ObtenerInventarioAsync(Servicios.Web.InvetanriosServiceReference.ObtenerInventarioRequest request) {
            return base.Channel.ObtenerInventarioAsync(request);
        }
        
        public System.Threading.Tasks.Task<Servicios.Web.InvetanriosServiceReference.ObtenerInventarioResponse> ObtenerInventarioAsync() {
            Servicios.Web.InvetanriosServiceReference.ObtenerInventarioRequest inValue = new Servicios.Web.InvetanriosServiceReference.ObtenerInventarioRequest();
            inValue.Body = new Servicios.Web.InvetanriosServiceReference.ObtenerInventarioRequestBody();
            return ((Servicios.Web.InvetanriosServiceReference.WebServiceInventarioSoap)(this)).ObtenerInventarioAsync(inValue);
        }
    }
}
