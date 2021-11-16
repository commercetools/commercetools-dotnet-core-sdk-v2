using System.Collections.Generic;


namespace commercetools.Api.Models.Me
{
    public partial class MyCustomerUpdate : IMyCustomerUpdate
    {
        public long Version { get; set;}
        
        public List<IMyCustomerUpdateAction> Actions { get; set;}
    }
}
