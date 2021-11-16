using commercetools.Api.Models.Types;


namespace commercetools.Api.Models.OrderEdits
{
    public partial class StagedOrderSetShippingAddressCustomTypeAction : IStagedOrderSetShippingAddressCustomTypeAction
    {
        public string Action { get; set;}
        
        public ITypeResourceIdentifier Type { get; set;}
        
        public IFieldContainer Fields { get; set;}
        public StagedOrderSetShippingAddressCustomTypeAction()
        { 
           this.Action = "setShippingAddressCustomType";
        }
    }
}
