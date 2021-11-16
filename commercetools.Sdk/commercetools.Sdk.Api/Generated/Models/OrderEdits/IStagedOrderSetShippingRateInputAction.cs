using commercetools.Api.Models.Carts;
using commercetools.Api.Models.Orders;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    [DeserializeAs(typeof(commercetools.Api.Models.OrderEdits.StagedOrderSetShippingRateInputAction))]
    public partial interface IStagedOrderSetShippingRateInputAction : IStagedOrderUpdateAction
    {
        IShippingRateInputDraft ShippingRateInput { get; set;}
    }
}
