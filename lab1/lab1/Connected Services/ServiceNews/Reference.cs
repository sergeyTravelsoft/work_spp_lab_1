﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace lab1.ServiceNews {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceNews.IServiceNews")]
    public interface IServiceNews {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceNews/GetNews", ReplyAction="http://tempuri.org/IServiceNews/GetNewsResponse")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(object[]))]
        object[] GetNews(System.Uri uri);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceNews/GetNews", ReplyAction="http://tempuri.org/IServiceNews/GetNewsResponse")]
        System.Threading.Tasks.Task<object[]> GetNewsAsync(System.Uri uri);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceNews/GetNewsSerialaized", ReplyAction="http://tempuri.org/IServiceNews/GetNewsSerialaizedResponse")]
        string GetNewsSerialaized(System.Uri uri);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceNews/GetNewsSerialaized", ReplyAction="http://tempuri.org/IServiceNews/GetNewsSerialaizedResponse")]
        System.Threading.Tasks.Task<string> GetNewsSerialaizedAsync(System.Uri uri);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceNews/SendEmail", ReplyAction="http://tempuri.org/IServiceNews/SendEmailResponse")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(object[]))]
        void SendEmail(object article, string receiversAddress);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceNews/SendEmail", ReplyAction="http://tempuri.org/IServiceNews/SendEmailResponse")]
        System.Threading.Tasks.Task SendEmailAsync(object article, string receiversAddress);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceNewsChannel : lab1.ServiceNews.IServiceNews, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceNewsClient : System.ServiceModel.ClientBase<lab1.ServiceNews.IServiceNews>, lab1.ServiceNews.IServiceNews {
        
        public ServiceNewsClient() {
        }
        
        public ServiceNewsClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceNewsClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceNewsClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceNewsClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public object[] GetNews(System.Uri uri) {
            return base.Channel.GetNews(uri);
        }
        
        public System.Threading.Tasks.Task<object[]> GetNewsAsync(System.Uri uri) {
            return base.Channel.GetNewsAsync(uri);
        }
        
        public string GetNewsSerialaized(System.Uri uri) {
            return base.Channel.GetNewsSerialaized(uri);
        }
        
        public System.Threading.Tasks.Task<string> GetNewsSerialaizedAsync(System.Uri uri) {
            return base.Channel.GetNewsSerialaizedAsync(uri);
        }
        
        public void SendEmail(object article, string receiversAddress) {
            base.Channel.SendEmail(article, receiversAddress);
        }
        
        public System.Threading.Tasks.Task SendEmailAsync(object article, string receiversAddress) {
            return base.Channel.SendEmailAsync(article, receiversAddress);
        }
    }
}
