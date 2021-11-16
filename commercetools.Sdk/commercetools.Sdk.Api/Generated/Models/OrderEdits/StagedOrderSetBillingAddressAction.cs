using commercetools.Api.Models.Common;


namespace commercetools.Api.Models.OrderEdits
{
    public partial class StagedOrderSetBillingAddressAction : IStagedOrderSetBillingAddressAction
    {
        public string Action { get; set;}
        
        public IBaseAddress Address { get; set;}
        public StagedOrderSetBillingAddressAction()
        { 
           this.Action = "setBillingAddress";
        }
    }
}
