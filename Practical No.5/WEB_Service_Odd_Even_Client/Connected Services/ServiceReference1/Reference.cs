﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WEB_Service_Odd_Even_Client.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.WebService_OddEvenSoap")]
    public interface WebService_OddEvenSoap {
        
        // CODEGEN: Generating message contract since element name testOddEvenResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/testOddEven", ReplyAction="*")]
        WEB_Service_Odd_Even_Client.ServiceReference1.testOddEvenResponse testOddEven(WEB_Service_Odd_Even_Client.ServiceReference1.testOddEvenRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/testOddEven", ReplyAction="*")]
        System.Threading.Tasks.Task<WEB_Service_Odd_Even_Client.ServiceReference1.testOddEvenResponse> testOddEvenAsync(WEB_Service_Odd_Even_Client.ServiceReference1.testOddEvenRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class testOddEvenRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="testOddEven", Namespace="http://tempuri.org/", Order=0)]
        public WEB_Service_Odd_Even_Client.ServiceReference1.testOddEvenRequestBody Body;
        
        public testOddEvenRequest() {
        }
        
        public testOddEvenRequest(WEB_Service_Odd_Even_Client.ServiceReference1.testOddEvenRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class testOddEvenRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int num;
        
        public testOddEvenRequestBody() {
        }
        
        public testOddEvenRequestBody(int num) {
            this.num = num;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class testOddEvenResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="testOddEvenResponse", Namespace="http://tempuri.org/", Order=0)]
        public WEB_Service_Odd_Even_Client.ServiceReference1.testOddEvenResponseBody Body;
        
        public testOddEvenResponse() {
        }
        
        public testOddEvenResponse(WEB_Service_Odd_Even_Client.ServiceReference1.testOddEvenResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class testOddEvenResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string testOddEvenResult;
        
        public testOddEvenResponseBody() {
        }
        
        public testOddEvenResponseBody(string testOddEvenResult) {
            this.testOddEvenResult = testOddEvenResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WebService_OddEvenSoapChannel : WEB_Service_Odd_Even_Client.ServiceReference1.WebService_OddEvenSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebService_OddEvenSoapClient : System.ServiceModel.ClientBase<WEB_Service_Odd_Even_Client.ServiceReference1.WebService_OddEvenSoap>, WEB_Service_Odd_Even_Client.ServiceReference1.WebService_OddEvenSoap {
        
        public WebService_OddEvenSoapClient() {
        }
        
        public WebService_OddEvenSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WebService_OddEvenSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebService_OddEvenSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebService_OddEvenSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WEB_Service_Odd_Even_Client.ServiceReference1.testOddEvenResponse WEB_Service_Odd_Even_Client.ServiceReference1.WebService_OddEvenSoap.testOddEven(WEB_Service_Odd_Even_Client.ServiceReference1.testOddEvenRequest request) {
            return base.Channel.testOddEven(request);
        }
        
        public string testOddEven(int num) {
            WEB_Service_Odd_Even_Client.ServiceReference1.testOddEvenRequest inValue = new WEB_Service_Odd_Even_Client.ServiceReference1.testOddEvenRequest();
            inValue.Body = new WEB_Service_Odd_Even_Client.ServiceReference1.testOddEvenRequestBody();
            inValue.Body.num = num;
            WEB_Service_Odd_Even_Client.ServiceReference1.testOddEvenResponse retVal = ((WEB_Service_Odd_Even_Client.ServiceReference1.WebService_OddEvenSoap)(this)).testOddEven(inValue);
            return retVal.Body.testOddEvenResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WEB_Service_Odd_Even_Client.ServiceReference1.testOddEvenResponse> WEB_Service_Odd_Even_Client.ServiceReference1.WebService_OddEvenSoap.testOddEvenAsync(WEB_Service_Odd_Even_Client.ServiceReference1.testOddEvenRequest request) {
            return base.Channel.testOddEvenAsync(request);
        }
        
        public System.Threading.Tasks.Task<WEB_Service_Odd_Even_Client.ServiceReference1.testOddEvenResponse> testOddEvenAsync(int num) {
            WEB_Service_Odd_Even_Client.ServiceReference1.testOddEvenRequest inValue = new WEB_Service_Odd_Even_Client.ServiceReference1.testOddEvenRequest();
            inValue.Body = new WEB_Service_Odd_Even_Client.ServiceReference1.testOddEvenRequestBody();
            inValue.Body.num = num;
            return ((WEB_Service_Odd_Even_Client.ServiceReference1.WebService_OddEvenSoap)(this)).testOddEvenAsync(inValue);
        }
    }
}
