using commercetools.Api.Models.Orders;
using commercetools.Api.Models.Types;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    [DeserializeAs(typeof(commercetools.Api.Models.OrderEdits.StagedOrderSetDeliveryCustomTypeAction))]
    public partial interface IStagedOrderSetDeliveryCustomTypeAction : IStagedOrderUpdateAction
    {
        string DeliveryId { get; set; }

        ITypeResourceIdentifier Type { get; set; }

        IFieldContainer Fields { get; set; }
    }
}
