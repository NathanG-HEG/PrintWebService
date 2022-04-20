﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Consol_test.localPrint {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="localPrint.IPrintWebService")]
    public interface IPrintWebService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPrintWebService/Print", ReplyAction="http://tempuri.org/IPrintWebService/PrintResponse")]
        bool Print(int nbCopies, string productName, int cardId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPrintWebService/Print", ReplyAction="http://tempuri.org/IPrintWebService/PrintResponse")]
        System.Threading.Tasks.Task<bool> PrintAsync(int nbCopies, string productName, int cardId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPrintWebService/TransferMoneyWithCardId", ReplyAction="http://tempuri.org/IPrintWebService/TransferMoneyWithCardIdResponse")]
        void TransferMoneyWithCardId(int cardId, decimal quota);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPrintWebService/TransferMoneyWithCardId", ReplyAction="http://tempuri.org/IPrintWebService/TransferMoneyWithCardIdResponse")]
        System.Threading.Tasks.Task TransferMoneyWithCardIdAsync(int cardId, decimal quota);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPrintWebService/TransferMoneyWithUsername", ReplyAction="http://tempuri.org/IPrintWebService/TransferMoneyWithUsernameResponse")]
        void TransferMoneyWithUsername(string userName, decimal quota);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPrintWebService/TransferMoneyWithUsername", ReplyAction="http://tempuri.org/IPrintWebService/TransferMoneyWithUsernameResponse")]
        System.Threading.Tasks.Task TransferMoneyWithUsernameAsync(string userName, decimal quota);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPrintWebService/GetUserByCardId", ReplyAction="http://tempuri.org/IPrintWebService/GetUserByCardIdResponse")]
        DTO.User GetUserByCardId(int cardId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPrintWebService/GetUserByCardId", ReplyAction="http://tempuri.org/IPrintWebService/GetUserByCardIdResponse")]
        System.Threading.Tasks.Task<DTO.User> GetUserByCardIdAsync(int cardId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPrintWebService/DebitAccount", ReplyAction="http://tempuri.org/IPrintWebService/DebitAccountResponse")]
        void DebitAccount(int nbCopies, string productName, int cardId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPrintWebService/DebitAccount", ReplyAction="http://tempuri.org/IPrintWebService/DebitAccountResponse")]
        System.Threading.Tasks.Task DebitAccountAsync(int nbCopies, string productName, int cardId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IPrintWebServiceChannel : Consol_test.localPrint.IPrintWebService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class PrintWebServiceClient : System.ServiceModel.ClientBase<Consol_test.localPrint.IPrintWebService>, Consol_test.localPrint.IPrintWebService {
        
        public PrintWebServiceClient() {
        }
        
        public PrintWebServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public PrintWebServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PrintWebServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PrintWebServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool Print(int nbCopies, string productName, int cardId) {
            return base.Channel.Print(nbCopies, productName, cardId);
        }
        
        public System.Threading.Tasks.Task<bool> PrintAsync(int nbCopies, string productName, int cardId) {
            return base.Channel.PrintAsync(nbCopies, productName, cardId);
        }
        
        public void TransferMoneyWithCardId(int cardId, decimal quota) {
            base.Channel.TransferMoneyWithCardId(cardId, quota);
        }
        
        public System.Threading.Tasks.Task TransferMoneyWithCardIdAsync(int cardId, decimal quota) {
            return base.Channel.TransferMoneyWithCardIdAsync(cardId, quota);
        }
        
        public void TransferMoneyWithUsername(string userName, decimal quota) {
            base.Channel.TransferMoneyWithUsername(userName, quota);
        }
        
        public System.Threading.Tasks.Task TransferMoneyWithUsernameAsync(string userName, decimal quota) {
            return base.Channel.TransferMoneyWithUsernameAsync(userName, quota);
        }
        
        public DTO.User GetUserByCardId(int cardId) {
            return base.Channel.GetUserByCardId(cardId);
        }
        
        public System.Threading.Tasks.Task<DTO.User> GetUserByCardIdAsync(int cardId) {
            return base.Channel.GetUserByCardIdAsync(cardId);
        }
        
        public void DebitAccount(int nbCopies, string productName, int cardId) {
            base.Channel.DebitAccount(nbCopies, productName, cardId);
        }
        
        public System.Threading.Tasks.Task DebitAccountAsync(int nbCopies, string productName, int cardId) {
            return base.Channel.DebitAccountAsync(nbCopies, productName, cardId);
        }
    }
}
