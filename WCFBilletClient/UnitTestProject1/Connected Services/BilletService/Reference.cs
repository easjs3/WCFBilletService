﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UnitTestProject1.BilletService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="BilletService.IBillet")]
    public interface IBillet {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBillet/MCPrisUdenRabatStorebælt", ReplyAction="http://tempuri.org/IBillet/MCPrisUdenRabatStorebæltResponse")]
        int MCPrisUdenRabatStorebælt();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBillet/MCPrisUdenRabatStorebælt", ReplyAction="http://tempuri.org/IBillet/MCPrisUdenRabatStorebæltResponse")]
        System.Threading.Tasks.Task<int> MCPrisUdenRabatStorebæltAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBillet/BilPrisUdenRabatStorebælt", ReplyAction="http://tempuri.org/IBillet/BilPrisUdenRabatStorebæltResponse")]
        int BilPrisUdenRabatStorebælt();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBillet/BilPrisUdenRabatStorebælt", ReplyAction="http://tempuri.org/IBillet/BilPrisUdenRabatStorebæltResponse")]
        System.Threading.Tasks.Task<int> BilPrisUdenRabatStorebæltAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBillet/BilPrisUdenRabatØresund", ReplyAction="http://tempuri.org/IBillet/BilPrisUdenRabatØresundResponse")]
        int BilPrisUdenRabatØresund();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBillet/BilPrisUdenRabatØresund", ReplyAction="http://tempuri.org/IBillet/BilPrisUdenRabatØresundResponse")]
        System.Threading.Tasks.Task<int> BilPrisUdenRabatØresundAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBillet/MCPrisUdenRabatØresund", ReplyAction="http://tempuri.org/IBillet/MCPrisUdenRabatØresundResponse")]
        int MCPrisUdenRabatØresund();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBillet/MCPrisUdenRabatØresund", ReplyAction="http://tempuri.org/IBillet/MCPrisUdenRabatØresundResponse")]
        System.Threading.Tasks.Task<int> MCPrisUdenRabatØresundAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IBilletChannel : UnitTestProject1.BilletService.IBillet, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class BilletClient : System.ServiceModel.ClientBase<UnitTestProject1.BilletService.IBillet>, UnitTestProject1.BilletService.IBillet {
        
        public BilletClient() {
        }
        
        public BilletClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public BilletClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BilletClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BilletClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int MCPrisUdenRabatStorebælt() {
            return base.Channel.MCPrisUdenRabatStorebælt();
        }
        
        public System.Threading.Tasks.Task<int> MCPrisUdenRabatStorebæltAsync() {
            return base.Channel.MCPrisUdenRabatStorebæltAsync();
        }
        
        public int BilPrisUdenRabatStorebælt() {
            return base.Channel.BilPrisUdenRabatStorebælt();
        }
        
        public System.Threading.Tasks.Task<int> BilPrisUdenRabatStorebæltAsync() {
            return base.Channel.BilPrisUdenRabatStorebæltAsync();
        }
        
        public int BilPrisUdenRabatØresund() {
            return base.Channel.BilPrisUdenRabatØresund();
        }
        
        public System.Threading.Tasks.Task<int> BilPrisUdenRabatØresundAsync() {
            return base.Channel.BilPrisUdenRabatØresundAsync();
        }
        
        public int MCPrisUdenRabatØresund() {
            return base.Channel.MCPrisUdenRabatØresund();
        }
        
        public System.Threading.Tasks.Task<int> MCPrisUdenRabatØresundAsync() {
            return base.Channel.MCPrisUdenRabatØresundAsync();
        }
    }
}
