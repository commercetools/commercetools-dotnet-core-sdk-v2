using commercetools.Api.Models.Orders;
using commercetools.Api.Models.Types;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    [DeserializeAs(typeof(commercetools.Api.Models.OrderEdits.StagedOrderSetLineItemCustomTypeAction))]
    public partial interface IStagedOrderSetLineItemCustomTypeAction : IStagedOrderUpdateAction
    {
        string LineItemId { get; set;}
        
        ITypeResourceIdentifier Type { get; set;}
        
        IFieldContainer Fields { get; set;}
    }
}
