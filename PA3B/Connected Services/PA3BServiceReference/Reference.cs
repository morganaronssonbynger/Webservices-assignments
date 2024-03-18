﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PA3B.PA3BServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="PA3BServiceReference.WebServicePA3Soap")]
    public interface WebServicePA3Soap {
        
        // CODEGEN: Generating message contract since element name fileName from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetFile", ReplyAction="*")]
        PA3B.PA3BServiceReference.GetFileResponse GetFile(PA3B.PA3BServiceReference.GetFileRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetFile", ReplyAction="*")]
        System.Threading.Tasks.Task<PA3B.PA3BServiceReference.GetFileResponse> GetFileAsync(PA3B.PA3BServiceReference.GetFileRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetFileRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetFile", Namespace="http://tempuri.org/", Order=0)]
        public PA3B.PA3BServiceReference.GetFileRequestBody Body;
        
        public GetFileRequest() {
        }
        
        public GetFileRequest(PA3B.PA3BServiceReference.GetFileRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetFileRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string fileName;
        
        public GetFileRequestBody() {
        }
        
        public GetFileRequestBody(string fileName) {
            this.fileName = fileName;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetFileResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetFileResponse", Namespace="http://tempuri.org/", Order=0)]
        public PA3B.PA3BServiceReference.GetFileResponseBody Body;
        
        public GetFileResponse() {
        }
        
        public GetFileResponse(PA3B.PA3BServiceReference.GetFileResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetFileResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string GetFileResult;
        
        public GetFileResponseBody() {
        }
        
        public GetFileResponseBody(string GetFileResult) {
            this.GetFileResult = GetFileResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WebServicePA3SoapChannel : PA3B.PA3BServiceReference.WebServicePA3Soap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebServicePA3SoapClient : System.ServiceModel.ClientBase<PA3B.PA3BServiceReference.WebServicePA3Soap>, PA3B.PA3BServiceReference.WebServicePA3Soap {
        
        public WebServicePA3SoapClient() {
        }
        
        public WebServicePA3SoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WebServicePA3SoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebServicePA3SoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebServicePA3SoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        PA3B.PA3BServiceReference.GetFileResponse PA3B.PA3BServiceReference.WebServicePA3Soap.GetFile(PA3B.PA3BServiceReference.GetFileRequest request) {
            return base.Channel.GetFile(request);
        }
        
        public string GetFile(string fileName) {
            PA3B.PA3BServiceReference.GetFileRequest inValue = new PA3B.PA3BServiceReference.GetFileRequest();
            inValue.Body = new PA3B.PA3BServiceReference.GetFileRequestBody();
            inValue.Body.fileName = fileName;
            PA3B.PA3BServiceReference.GetFileResponse retVal = ((PA3B.PA3BServiceReference.WebServicePA3Soap)(this)).GetFile(inValue);
            return retVal.Body.GetFileResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<PA3B.PA3BServiceReference.GetFileResponse> PA3B.PA3BServiceReference.WebServicePA3Soap.GetFileAsync(PA3B.PA3BServiceReference.GetFileRequest request) {
            return base.Channel.GetFileAsync(request);
        }
        
        public System.Threading.Tasks.Task<PA3B.PA3BServiceReference.GetFileResponse> GetFileAsync(string fileName) {
            PA3B.PA3BServiceReference.GetFileRequest inValue = new PA3B.PA3BServiceReference.GetFileRequest();
            inValue.Body = new PA3B.PA3BServiceReference.GetFileRequestBody();
            inValue.Body.fileName = fileName;
            return ((PA3B.PA3BServiceReference.WebServicePA3Soap)(this)).GetFileAsync(inValue);
        }
    }
}