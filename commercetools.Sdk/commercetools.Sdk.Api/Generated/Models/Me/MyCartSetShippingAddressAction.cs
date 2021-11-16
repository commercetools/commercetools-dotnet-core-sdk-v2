using commercetools.Api.Models.Common;


namespace commercetools.Api.Models.Me
{
    public partial class MyCartSetShippingAddressAction : IMyCartSetShippingAddressAction
    {
        public string Action { get; set;}
        
        public IBaseAddress Address { get; set;}
        public MyCartSetShippingAddressAction()
        { 
           this.Action = "setShippingAddress";
        }
    }
}
