﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Transportes_3_capas.CalculadoraService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="CalculadoraService.calculadora_ServiceSoap")]
    public interface calculadora_ServiceSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Suma", ReplyAction="*")]
        double Suma(double a, double b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Suma", ReplyAction="*")]
        System.Threading.Tasks.Task<double> SumaAsync(double a, double b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Resta", ReplyAction="*")]
        double Resta(double a, double b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Resta", ReplyAction="*")]
        System.Threading.Tasks.Task<double> RestaAsync(double a, double b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/multiplicacion", ReplyAction="*")]
        double multiplicacion(double a, double b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/multiplicacion", ReplyAction="*")]
        System.Threading.Tasks.Task<double> multiplicacionAsync(double a, double b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/division", ReplyAction="*")]
        double division(double a, double b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/division", ReplyAction="*")]
        System.Threading.Tasks.Task<double> divisionAsync(double a, double b);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface calculadora_ServiceSoapChannel : Transportes_3_capas.CalculadoraService.calculadora_ServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class calculadora_ServiceSoapClient : System.ServiceModel.ClientBase<Transportes_3_capas.CalculadoraService.calculadora_ServiceSoap>, Transportes_3_capas.CalculadoraService.calculadora_ServiceSoap {
        
        public calculadora_ServiceSoapClient() {
        }
        
        public calculadora_ServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public calculadora_ServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public calculadora_ServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public calculadora_ServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public double Suma(double a, double b) {
            return base.Channel.Suma(a, b);
        }
        
        public System.Threading.Tasks.Task<double> SumaAsync(double a, double b) {
            return base.Channel.SumaAsync(a, b);
        }
        
        public double Resta(double a, double b) {
            return base.Channel.Resta(a, b);
        }
        
        public System.Threading.Tasks.Task<double> RestaAsync(double a, double b) {
            return base.Channel.RestaAsync(a, b);
        }
        
        public double multiplicacion(double a, double b) {
            return base.Channel.multiplicacion(a, b);
        }
        
        public System.Threading.Tasks.Task<double> multiplicacionAsync(double a, double b) {
            return base.Channel.multiplicacionAsync(a, b);
        }
        
        public double division(double a, double b) {
            return base.Channel.division(a, b);
        }
        
        public System.Threading.Tasks.Task<double> divisionAsync(double a, double b) {
            return base.Channel.divisionAsync(a, b);
        }
    }
}
