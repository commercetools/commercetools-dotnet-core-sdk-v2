using commercetools.Api.Models.Common;


namespace commercetools.Api.Models.OrderEdits
{
    public partial class StagedOrderSetShippingAddressAction : IStagedOrderSetShippingAddressAction
    {
        public string Action { get; set;}
        
        public IBaseAddress Address { get; set;}
        public StagedOrderSetShippingAddressAction()
        { 
           this.Action = "setShippingAddress";
        }
    }
}
