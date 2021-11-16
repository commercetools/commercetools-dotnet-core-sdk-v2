using commercetools.Api.Models.Common;


namespace commercetools.Api.Models.Me
{
    public partial class MyCartSetBillingAddressAction : IMyCartSetBillingAddressAction
    {
        public string Action { get; set;}
        
        public IBaseAddress Address { get; set;}
        public MyCartSetBillingAddressAction()
        { 
           this.Action = "setBillingAddress";
        }
    }
}
