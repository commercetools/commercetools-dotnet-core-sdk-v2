using commercetools.Api.Models.Common;


namespace commercetools.Api.Models.OrderEdits
{
    public partial class StagedOrderAddItemShippingAddressAction : IStagedOrderAddItemShippingAddressAction
    {
        public string Action { get; set;}
        
        public IBaseAddress Address { get; set;}
        public StagedOrderAddItemShippingAddressAction()
        { 
           this.Action = "addItemShippingAddress";
        }
    }
}
