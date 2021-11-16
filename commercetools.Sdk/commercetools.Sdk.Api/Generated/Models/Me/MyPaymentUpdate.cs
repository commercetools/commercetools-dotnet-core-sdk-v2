using System.Collections.Generic;


namespace commercetools.Api.Models.Me
{
    public partial class MyPaymentUpdate : IMyPaymentUpdate
    {
        public long Version { get; set;}
        
        public List<IMyPaymentUpdateAction> Actions { get; set;}
    }
}
