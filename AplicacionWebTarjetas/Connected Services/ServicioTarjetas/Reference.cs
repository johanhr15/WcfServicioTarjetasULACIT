﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AplicacionWebTarjetas.ServicioTarjetas {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CompositeType", Namespace="http://schemas.datacontract.org/2004/07/WcfServicioTarjetasULACIT")]
    [System.SerializableAttribute()]
    public partial class CompositeType : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool BoolValueField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StringValueField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool BoolValue {
            get {
                return this.BoolValueField;
            }
            set {
                if ((this.BoolValueField.Equals(value) != true)) {
                    this.BoolValueField = value;
                    this.RaisePropertyChanged("BoolValue");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string StringValue {
            get {
                return this.StringValueField;
            }
            set {
                if ((object.ReferenceEquals(this.StringValueField, value) != true)) {
                    this.StringValueField = value;
                    this.RaisePropertyChanged("StringValue");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Emisor", Namespace="http://schemas.datacontract.org/2004/07/WcfServicioTarjetasULACIT.Models")]
    [System.SerializableAttribute()]
    public partial class Emisor : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int EMI_CODIGOField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EMI_DESCRIPCIONField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int EMI_NUMERO_MAX_DIGITOSField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EMI_PREFIJOField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int EMI_CODIGO {
            get {
                return this.EMI_CODIGOField;
            }
            set {
                if ((this.EMI_CODIGOField.Equals(value) != true)) {
                    this.EMI_CODIGOField = value;
                    this.RaisePropertyChanged("EMI_CODIGO");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string EMI_DESCRIPCION {
            get {
                return this.EMI_DESCRIPCIONField;
            }
            set {
                if ((object.ReferenceEquals(this.EMI_DESCRIPCIONField, value) != true)) {
                    this.EMI_DESCRIPCIONField = value;
                    this.RaisePropertyChanged("EMI_DESCRIPCION");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int EMI_NUMERO_MAX_DIGITOS {
            get {
                return this.EMI_NUMERO_MAX_DIGITOSField;
            }
            set {
                if ((this.EMI_NUMERO_MAX_DIGITOSField.Equals(value) != true)) {
                    this.EMI_NUMERO_MAX_DIGITOSField = value;
                    this.RaisePropertyChanged("EMI_NUMERO_MAX_DIGITOS");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string EMI_PREFIJO {
            get {
                return this.EMI_PREFIJOField;
            }
            set {
                if ((object.ReferenceEquals(this.EMI_PREFIJOField, value) != true)) {
                    this.EMI_PREFIJOField = value;
                    this.RaisePropertyChanged("EMI_PREFIJO");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Tarjeta", Namespace="http://schemas.datacontract.org/2004/07/WcfServicioTarjetasULACIT.Models")]
    [System.SerializableAttribute()]
    public partial class Tarjeta : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int TAR_CODIGOField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int TAR_CODIGO_CLIENTEField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TAR_ESTADOField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime TAR_FECHA_EMISIONField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime TAR_FECHA_VENCIMIENTOField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TAR_NOMBRE_CLIENTEField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TAR_NUMEROField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal TAR_SALDOField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TAR_TIPOField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int TAR_CODIGO {
            get {
                return this.TAR_CODIGOField;
            }
            set {
                if ((this.TAR_CODIGOField.Equals(value) != true)) {
                    this.TAR_CODIGOField = value;
                    this.RaisePropertyChanged("TAR_CODIGO");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int TAR_CODIGO_CLIENTE {
            get {
                return this.TAR_CODIGO_CLIENTEField;
            }
            set {
                if ((this.TAR_CODIGO_CLIENTEField.Equals(value) != true)) {
                    this.TAR_CODIGO_CLIENTEField = value;
                    this.RaisePropertyChanged("TAR_CODIGO_CLIENTE");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string TAR_ESTADO {
            get {
                return this.TAR_ESTADOField;
            }
            set {
                if ((object.ReferenceEquals(this.TAR_ESTADOField, value) != true)) {
                    this.TAR_ESTADOField = value;
                    this.RaisePropertyChanged("TAR_ESTADO");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime TAR_FECHA_EMISION {
            get {
                return this.TAR_FECHA_EMISIONField;
            }
            set {
                if ((this.TAR_FECHA_EMISIONField.Equals(value) != true)) {
                    this.TAR_FECHA_EMISIONField = value;
                    this.RaisePropertyChanged("TAR_FECHA_EMISION");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime TAR_FECHA_VENCIMIENTO {
            get {
                return this.TAR_FECHA_VENCIMIENTOField;
            }
            set {
                if ((this.TAR_FECHA_VENCIMIENTOField.Equals(value) != true)) {
                    this.TAR_FECHA_VENCIMIENTOField = value;
                    this.RaisePropertyChanged("TAR_FECHA_VENCIMIENTO");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string TAR_NOMBRE_CLIENTE {
            get {
                return this.TAR_NOMBRE_CLIENTEField;
            }
            set {
                if ((object.ReferenceEquals(this.TAR_NOMBRE_CLIENTEField, value) != true)) {
                    this.TAR_NOMBRE_CLIENTEField = value;
                    this.RaisePropertyChanged("TAR_NOMBRE_CLIENTE");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string TAR_NUMERO {
            get {
                return this.TAR_NUMEROField;
            }
            set {
                if ((object.ReferenceEquals(this.TAR_NUMEROField, value) != true)) {
                    this.TAR_NUMEROField = value;
                    this.RaisePropertyChanged("TAR_NUMERO");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal TAR_SALDO {
            get {
                return this.TAR_SALDOField;
            }
            set {
                if ((this.TAR_SALDOField.Equals(value) != true)) {
                    this.TAR_SALDOField = value;
                    this.RaisePropertyChanged("TAR_SALDO");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string TAR_TIPO {
            get {
                return this.TAR_TIPOField;
            }
            set {
                if ((object.ReferenceEquals(this.TAR_TIPOField, value) != true)) {
                    this.TAR_TIPOField = value;
                    this.RaisePropertyChanged("TAR_TIPO");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServicioTarjetas.ITarjetas")]
    public interface ITarjetas {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITarjetas/GetData", ReplyAction="http://tempuri.org/ITarjetas/GetDataResponse")]
        string GetData(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITarjetas/GetData", ReplyAction="http://tempuri.org/ITarjetas/GetDataResponse")]
        System.Threading.Tasks.Task<string> GetDataAsync(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITarjetas/GetDataUsingDataContract", ReplyAction="http://tempuri.org/ITarjetas/GetDataUsingDataContractResponse")]
        AplicacionWebTarjetas.ServicioTarjetas.CompositeType GetDataUsingDataContract(AplicacionWebTarjetas.ServicioTarjetas.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITarjetas/GetDataUsingDataContract", ReplyAction="http://tempuri.org/ITarjetas/GetDataUsingDataContractResponse")]
        System.Threading.Tasks.Task<AplicacionWebTarjetas.ServicioTarjetas.CompositeType> GetDataUsingDataContractAsync(AplicacionWebTarjetas.ServicioTarjetas.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITarjetas/ConsultarEmisores", ReplyAction="http://tempuri.org/ITarjetas/ConsultarEmisoresResponse")]
        AplicacionWebTarjetas.ServicioTarjetas.Emisor[] ConsultarEmisores();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITarjetas/ConsultarEmisores", ReplyAction="http://tempuri.org/ITarjetas/ConsultarEmisoresResponse")]
        System.Threading.Tasks.Task<AplicacionWebTarjetas.ServicioTarjetas.Emisor[]> ConsultarEmisoresAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITarjetas/ConsultarEmisoresPorDescripcion", ReplyAction="http://tempuri.org/ITarjetas/ConsultarEmisoresPorDescripcionResponse")]
        AplicacionWebTarjetas.ServicioTarjetas.Emisor[] ConsultarEmisoresPorDescripcion(string descripcion);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITarjetas/ConsultarEmisoresPorDescripcion", ReplyAction="http://tempuri.org/ITarjetas/ConsultarEmisoresPorDescripcionResponse")]
        System.Threading.Tasks.Task<AplicacionWebTarjetas.ServicioTarjetas.Emisor[]> ConsultarEmisoresPorDescripcionAsync(string descripcion);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITarjetas/ConsultarEmisorPorNumeroTarjeta", ReplyAction="http://tempuri.org/ITarjetas/ConsultarEmisorPorNumeroTarjetaResponse")]
        AplicacionWebTarjetas.ServicioTarjetas.Emisor[] ConsultarEmisorPorNumeroTarjeta(string numero);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITarjetas/ConsultarEmisorPorNumeroTarjeta", ReplyAction="http://tempuri.org/ITarjetas/ConsultarEmisorPorNumeroTarjetaResponse")]
        System.Threading.Tasks.Task<AplicacionWebTarjetas.ServicioTarjetas.Emisor[]> ConsultarEmisorPorNumeroTarjetaAsync(string numero);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITarjetas/ConsultarInformacionTarjeta", ReplyAction="http://tempuri.org/ITarjetas/ConsultarInformacionTarjetaResponse")]
        AplicacionWebTarjetas.ServicioTarjetas.Tarjeta[] ConsultarInformacionTarjeta(string numero);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITarjetas/ConsultarInformacionTarjeta", ReplyAction="http://tempuri.org/ITarjetas/ConsultarInformacionTarjetaResponse")]
        System.Threading.Tasks.Task<AplicacionWebTarjetas.ServicioTarjetas.Tarjeta[]> ConsultarInformacionTarjetaAsync(string numero);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ITarjetasChannel : AplicacionWebTarjetas.ServicioTarjetas.ITarjetas, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class TarjetasClient : System.ServiceModel.ClientBase<AplicacionWebTarjetas.ServicioTarjetas.ITarjetas>, AplicacionWebTarjetas.ServicioTarjetas.ITarjetas {
        
        public TarjetasClient() {
        }
        
        public TarjetasClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public TarjetasClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TarjetasClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TarjetasClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetData(int value) {
            return base.Channel.GetData(value);
        }
        
        public System.Threading.Tasks.Task<string> GetDataAsync(int value) {
            return base.Channel.GetDataAsync(value);
        }
        
        public AplicacionWebTarjetas.ServicioTarjetas.CompositeType GetDataUsingDataContract(AplicacionWebTarjetas.ServicioTarjetas.CompositeType composite) {
            return base.Channel.GetDataUsingDataContract(composite);
        }
        
        public System.Threading.Tasks.Task<AplicacionWebTarjetas.ServicioTarjetas.CompositeType> GetDataUsingDataContractAsync(AplicacionWebTarjetas.ServicioTarjetas.CompositeType composite) {
            return base.Channel.GetDataUsingDataContractAsync(composite);
        }
        
        public AplicacionWebTarjetas.ServicioTarjetas.Emisor[] ConsultarEmisores() {
            return base.Channel.ConsultarEmisores();
        }
        
        public System.Threading.Tasks.Task<AplicacionWebTarjetas.ServicioTarjetas.Emisor[]> ConsultarEmisoresAsync() {
            return base.Channel.ConsultarEmisoresAsync();
        }
        
        public AplicacionWebTarjetas.ServicioTarjetas.Emisor[] ConsultarEmisoresPorDescripcion(string descripcion) {
            return base.Channel.ConsultarEmisoresPorDescripcion(descripcion);
        }
        
        public System.Threading.Tasks.Task<AplicacionWebTarjetas.ServicioTarjetas.Emisor[]> ConsultarEmisoresPorDescripcionAsync(string descripcion) {
            return base.Channel.ConsultarEmisoresPorDescripcionAsync(descripcion);
        }
        
        public AplicacionWebTarjetas.ServicioTarjetas.Emisor[] ConsultarEmisorPorNumeroTarjeta(string numero) {
            return base.Channel.ConsultarEmisorPorNumeroTarjeta(numero);
        }
        
        public System.Threading.Tasks.Task<AplicacionWebTarjetas.ServicioTarjetas.Emisor[]> ConsultarEmisorPorNumeroTarjetaAsync(string numero) {
            return base.Channel.ConsultarEmisorPorNumeroTarjetaAsync(numero);
        }
        
        public AplicacionWebTarjetas.ServicioTarjetas.Tarjeta[] ConsultarInformacionTarjeta(string numero) {
            return base.Channel.ConsultarInformacionTarjeta(numero);
        }
        
        public System.Threading.Tasks.Task<AplicacionWebTarjetas.ServicioTarjetas.Tarjeta[]> ConsultarInformacionTarjetaAsync(string numero) {
            return base.Channel.ConsultarInformacionTarjetaAsync(numero);
        }
    }
}
