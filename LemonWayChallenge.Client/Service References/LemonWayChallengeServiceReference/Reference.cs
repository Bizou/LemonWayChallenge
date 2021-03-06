﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LemonWayChallenge.Client.LemonWayChallengeServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://romainduclos.com/webservices/", ConfigurationName="LemonWayChallengeServiceReference.ServiceSoap")]
    public interface ServiceSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://romainduclos.com/webservices/Fibonacci", ReplyAction="*")]
        int Fibonacci(int n);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://romainduclos.com/webservices/Fibonacci", ReplyAction="*")]
        System.Threading.Tasks.Task<int> FibonacciAsync(int n);
        
        // CODEGEN : La génération du contrat de message depuis le nom d'élément xml de l'espace de noms http://romainduclos.com/webservices/ n'est pas marqué nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://romainduclos.com/webservices/XmlToJson", ReplyAction="*")]
        LemonWayChallenge.Client.LemonWayChallengeServiceReference.XmlToJsonResponse XmlToJson(LemonWayChallenge.Client.LemonWayChallengeServiceReference.XmlToJsonRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://romainduclos.com/webservices/XmlToJson", ReplyAction="*")]
        System.Threading.Tasks.Task<LemonWayChallenge.Client.LemonWayChallengeServiceReference.XmlToJsonResponse> XmlToJsonAsync(LemonWayChallenge.Client.LemonWayChallengeServiceReference.XmlToJsonRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class XmlToJsonRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="XmlToJson", Namespace="http://romainduclos.com/webservices/", Order=0)]
        public LemonWayChallenge.Client.LemonWayChallengeServiceReference.XmlToJsonRequestBody Body;
        
        public XmlToJsonRequest() {
        }
        
        public XmlToJsonRequest(LemonWayChallenge.Client.LemonWayChallengeServiceReference.XmlToJsonRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://romainduclos.com/webservices/")]
    public partial class XmlToJsonRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string xml;
        
        public XmlToJsonRequestBody() {
        }
        
        public XmlToJsonRequestBody(string xml) {
            this.xml = xml;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class XmlToJsonResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="XmlToJsonResponse", Namespace="http://romainduclos.com/webservices/", Order=0)]
        public LemonWayChallenge.Client.LemonWayChallengeServiceReference.XmlToJsonResponseBody Body;
        
        public XmlToJsonResponse() {
        }
        
        public XmlToJsonResponse(LemonWayChallenge.Client.LemonWayChallengeServiceReference.XmlToJsonResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://romainduclos.com/webservices/")]
    public partial class XmlToJsonResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string XmlToJsonResult;
        
        public XmlToJsonResponseBody() {
        }
        
        public XmlToJsonResponseBody(string XmlToJsonResult) {
            this.XmlToJsonResult = XmlToJsonResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ServiceSoapChannel : LemonWayChallenge.Client.LemonWayChallengeServiceReference.ServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceSoapClient : System.ServiceModel.ClientBase<LemonWayChallenge.Client.LemonWayChallengeServiceReference.ServiceSoap>, LemonWayChallenge.Client.LemonWayChallengeServiceReference.ServiceSoap {
        
        public ServiceSoapClient() {
        }
        
        public ServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int Fibonacci(int n) {
            return base.Channel.Fibonacci(n);
        }
        
        public System.Threading.Tasks.Task<int> FibonacciAsync(int n) {
            return base.Channel.FibonacciAsync(n);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        LemonWayChallenge.Client.LemonWayChallengeServiceReference.XmlToJsonResponse LemonWayChallenge.Client.LemonWayChallengeServiceReference.ServiceSoap.XmlToJson(LemonWayChallenge.Client.LemonWayChallengeServiceReference.XmlToJsonRequest request) {
            return base.Channel.XmlToJson(request);
        }
        
        public string XmlToJson(string xml) {
            LemonWayChallenge.Client.LemonWayChallengeServiceReference.XmlToJsonRequest inValue = new LemonWayChallenge.Client.LemonWayChallengeServiceReference.XmlToJsonRequest();
            inValue.Body = new LemonWayChallenge.Client.LemonWayChallengeServiceReference.XmlToJsonRequestBody();
            inValue.Body.xml = xml;
            LemonWayChallenge.Client.LemonWayChallengeServiceReference.XmlToJsonResponse retVal = ((LemonWayChallenge.Client.LemonWayChallengeServiceReference.ServiceSoap)(this)).XmlToJson(inValue);
            return retVal.Body.XmlToJsonResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<LemonWayChallenge.Client.LemonWayChallengeServiceReference.XmlToJsonResponse> LemonWayChallenge.Client.LemonWayChallengeServiceReference.ServiceSoap.XmlToJsonAsync(LemonWayChallenge.Client.LemonWayChallengeServiceReference.XmlToJsonRequest request) {
            return base.Channel.XmlToJsonAsync(request);
        }
        
        public System.Threading.Tasks.Task<LemonWayChallenge.Client.LemonWayChallengeServiceReference.XmlToJsonResponse> XmlToJsonAsync(string xml) {
            LemonWayChallenge.Client.LemonWayChallengeServiceReference.XmlToJsonRequest inValue = new LemonWayChallenge.Client.LemonWayChallengeServiceReference.XmlToJsonRequest();
            inValue.Body = new LemonWayChallenge.Client.LemonWayChallengeServiceReference.XmlToJsonRequestBody();
            inValue.Body.xml = xml;
            return ((LemonWayChallenge.Client.LemonWayChallengeServiceReference.ServiceSoap)(this)).XmlToJsonAsync(inValue);
        }
    }
}
