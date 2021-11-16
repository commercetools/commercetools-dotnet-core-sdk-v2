using commercetools.Api.Models.Common;


namespace commercetools.Api.Models.Me
{
    public partial class MyCartUpdateItemShippingAddressAction : IMyCartUpdateItemShippingAddressAction
    {
        public string Action { get; set;}
        
        public IBaseAddress Address { get; set;}
        public MyCartUpdateItemShippingAddressAction()
        { 
           this.Action = "updateItemShippingAddress";
        }
    }
}
