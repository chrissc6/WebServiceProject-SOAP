﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebServiceProject.ServiceRef {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.CollectionDataContractAttribute(Name="ArrayOfInt", Namespace="http://tempuri.org/", ItemName="int")]
    [System.SerializableAttribute()]
    public class ArrayOfInt : System.Collections.Generic.List<int> {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Person", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class Person : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string firstNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string lastNameField;
        
        private int ageField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string firstName {
            get {
                return this.firstNameField;
            }
            set {
                if ((object.ReferenceEquals(this.firstNameField, value) != true)) {
                    this.firstNameField = value;
                    this.RaisePropertyChanged("firstName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string lastName {
            get {
                return this.lastNameField;
            }
            set {
                if ((object.ReferenceEquals(this.lastNameField, value) != true)) {
                    this.lastNameField = value;
                    this.RaisePropertyChanged("lastName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=2)]
        public int age {
            get {
                return this.ageField;
            }
            set {
                if ((this.ageField.Equals(value) != true)) {
                    this.ageField = value;
                    this.RaisePropertyChanged("age");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceRef.WebSerSoap")]
    public interface WebSerSoap {
        
        // CODEGEN: Generating message contract since element name HelloWorldResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        WebServiceProject.ServiceRef.HelloWorldResponse HelloWorld(WebServiceProject.ServiceRef.HelloWorldRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        System.Threading.Tasks.Task<WebServiceProject.ServiceRef.HelloWorldResponse> HelloWorldAsync(WebServiceProject.ServiceRef.HelloWorldRequest request);
        
        // CODEGEN: Generating message contract since element name listInt from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Add", ReplyAction="*")]
        WebServiceProject.ServiceRef.AddResponse Add(WebServiceProject.ServiceRef.AddRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Add", ReplyAction="*")]
        System.Threading.Tasks.Task<WebServiceProject.ServiceRef.AddResponse> AddAsync(WebServiceProject.ServiceRef.AddRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Multiply", ReplyAction="*")]
        int Multiply(int x, int y);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Multiply", ReplyAction="*")]
        System.Threading.Tasks.Task<int> MultiplyAsync(int x, int y);
        
        // CODEGEN: Generating message contract since element name p from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/DoSomething", ReplyAction="*")]
        WebServiceProject.ServiceRef.DoSomethingResponse DoSomething(WebServiceProject.ServiceRef.DoSomethingRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/DoSomething", ReplyAction="*")]
        System.Threading.Tasks.Task<WebServiceProject.ServiceRef.DoSomethingResponse> DoSomethingAsync(WebServiceProject.ServiceRef.DoSomethingRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorld", Namespace="http://tempuri.org/", Order=0)]
        public WebServiceProject.ServiceRef.HelloWorldRequestBody Body;
        
        public HelloWorldRequest() {
        }
        
        public HelloWorldRequest(WebServiceProject.ServiceRef.HelloWorldRequestBody Body) {
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
        public WebServiceProject.ServiceRef.HelloWorldResponseBody Body;
        
        public HelloWorldResponse() {
        }
        
        public HelloWorldResponse(WebServiceProject.ServiceRef.HelloWorldResponseBody Body) {
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
    public partial class AddRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Add", Namespace="http://tempuri.org/", Order=0)]
        public WebServiceProject.ServiceRef.AddRequestBody Body;
        
        public AddRequest() {
        }
        
        public AddRequest(WebServiceProject.ServiceRef.AddRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class AddRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public WebServiceProject.ServiceRef.ArrayOfInt listInt;
        
        public AddRequestBody() {
        }
        
        public AddRequestBody(WebServiceProject.ServiceRef.ArrayOfInt listInt) {
            this.listInt = listInt;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AddResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="AddResponse", Namespace="http://tempuri.org/", Order=0)]
        public WebServiceProject.ServiceRef.AddResponseBody Body;
        
        public AddResponse() {
        }
        
        public AddResponse(WebServiceProject.ServiceRef.AddResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class AddResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int AddResult;
        
        public AddResponseBody() {
        }
        
        public AddResponseBody(int AddResult) {
            this.AddResult = AddResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class DoSomethingRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="DoSomething", Namespace="http://tempuri.org/", Order=0)]
        public WebServiceProject.ServiceRef.DoSomethingRequestBody Body;
        
        public DoSomethingRequest() {
        }
        
        public DoSomethingRequest(WebServiceProject.ServiceRef.DoSomethingRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class DoSomethingRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public WebServiceProject.ServiceRef.Person p;
        
        public DoSomethingRequestBody() {
        }
        
        public DoSomethingRequestBody(WebServiceProject.ServiceRef.Person p) {
            this.p = p;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class DoSomethingResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="DoSomethingResponse", Namespace="http://tempuri.org/", Order=0)]
        public WebServiceProject.ServiceRef.DoSomethingResponseBody Body;
        
        public DoSomethingResponse() {
        }
        
        public DoSomethingResponse(WebServiceProject.ServiceRef.DoSomethingResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class DoSomethingResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string DoSomethingResult;
        
        public DoSomethingResponseBody() {
        }
        
        public DoSomethingResponseBody(string DoSomethingResult) {
            this.DoSomethingResult = DoSomethingResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WebSerSoapChannel : WebServiceProject.ServiceRef.WebSerSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebSerSoapClient : System.ServiceModel.ClientBase<WebServiceProject.ServiceRef.WebSerSoap>, WebServiceProject.ServiceRef.WebSerSoap {
        
        public WebSerSoapClient() {
        }
        
        public WebSerSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WebSerSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebSerSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebSerSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WebServiceProject.ServiceRef.HelloWorldResponse WebServiceProject.ServiceRef.WebSerSoap.HelloWorld(WebServiceProject.ServiceRef.HelloWorldRequest request) {
            return base.Channel.HelloWorld(request);
        }
        
        public string HelloWorld() {
            WebServiceProject.ServiceRef.HelloWorldRequest inValue = new WebServiceProject.ServiceRef.HelloWorldRequest();
            inValue.Body = new WebServiceProject.ServiceRef.HelloWorldRequestBody();
            WebServiceProject.ServiceRef.HelloWorldResponse retVal = ((WebServiceProject.ServiceRef.WebSerSoap)(this)).HelloWorld(inValue);
            return retVal.Body.HelloWorldResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WebServiceProject.ServiceRef.HelloWorldResponse> WebServiceProject.ServiceRef.WebSerSoap.HelloWorldAsync(WebServiceProject.ServiceRef.HelloWorldRequest request) {
            return base.Channel.HelloWorldAsync(request);
        }
        
        public System.Threading.Tasks.Task<WebServiceProject.ServiceRef.HelloWorldResponse> HelloWorldAsync() {
            WebServiceProject.ServiceRef.HelloWorldRequest inValue = new WebServiceProject.ServiceRef.HelloWorldRequest();
            inValue.Body = new WebServiceProject.ServiceRef.HelloWorldRequestBody();
            return ((WebServiceProject.ServiceRef.WebSerSoap)(this)).HelloWorldAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WebServiceProject.ServiceRef.AddResponse WebServiceProject.ServiceRef.WebSerSoap.Add(WebServiceProject.ServiceRef.AddRequest request) {
            return base.Channel.Add(request);
        }
        
        public int Add(WebServiceProject.ServiceRef.ArrayOfInt listInt) {
            WebServiceProject.ServiceRef.AddRequest inValue = new WebServiceProject.ServiceRef.AddRequest();
            inValue.Body = new WebServiceProject.ServiceRef.AddRequestBody();
            inValue.Body.listInt = listInt;
            WebServiceProject.ServiceRef.AddResponse retVal = ((WebServiceProject.ServiceRef.WebSerSoap)(this)).Add(inValue);
            return retVal.Body.AddResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WebServiceProject.ServiceRef.AddResponse> WebServiceProject.ServiceRef.WebSerSoap.AddAsync(WebServiceProject.ServiceRef.AddRequest request) {
            return base.Channel.AddAsync(request);
        }
        
        public System.Threading.Tasks.Task<WebServiceProject.ServiceRef.AddResponse> AddAsync(WebServiceProject.ServiceRef.ArrayOfInt listInt) {
            WebServiceProject.ServiceRef.AddRequest inValue = new WebServiceProject.ServiceRef.AddRequest();
            inValue.Body = new WebServiceProject.ServiceRef.AddRequestBody();
            inValue.Body.listInt = listInt;
            return ((WebServiceProject.ServiceRef.WebSerSoap)(this)).AddAsync(inValue);
        }
        
        public int Multiply(int x, int y) {
            return base.Channel.Multiply(x, y);
        }
        
        public System.Threading.Tasks.Task<int> MultiplyAsync(int x, int y) {
            return base.Channel.MultiplyAsync(x, y);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WebServiceProject.ServiceRef.DoSomethingResponse WebServiceProject.ServiceRef.WebSerSoap.DoSomething(WebServiceProject.ServiceRef.DoSomethingRequest request) {
            return base.Channel.DoSomething(request);
        }
        
        public string DoSomething(WebServiceProject.ServiceRef.Person p) {
            WebServiceProject.ServiceRef.DoSomethingRequest inValue = new WebServiceProject.ServiceRef.DoSomethingRequest();
            inValue.Body = new WebServiceProject.ServiceRef.DoSomethingRequestBody();
            inValue.Body.p = p;
            WebServiceProject.ServiceRef.DoSomethingResponse retVal = ((WebServiceProject.ServiceRef.WebSerSoap)(this)).DoSomething(inValue);
            return retVal.Body.DoSomethingResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WebServiceProject.ServiceRef.DoSomethingResponse> WebServiceProject.ServiceRef.WebSerSoap.DoSomethingAsync(WebServiceProject.ServiceRef.DoSomethingRequest request) {
            return base.Channel.DoSomethingAsync(request);
        }
        
        public System.Threading.Tasks.Task<WebServiceProject.ServiceRef.DoSomethingResponse> DoSomethingAsync(WebServiceProject.ServiceRef.Person p) {
            WebServiceProject.ServiceRef.DoSomethingRequest inValue = new WebServiceProject.ServiceRef.DoSomethingRequest();
            inValue.Body = new WebServiceProject.ServiceRef.DoSomethingRequestBody();
            inValue.Body.p = p;
            return ((WebServiceProject.ServiceRef.WebSerSoap)(this)).DoSomethingAsync(inValue);
        }
    }
}
