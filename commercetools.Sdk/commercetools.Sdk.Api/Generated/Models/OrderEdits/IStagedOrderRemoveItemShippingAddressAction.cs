using commercetools.Api.Models.Orders;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    [DeserializeAs(typeof(commercetools.Api.Models.OrderEdits.StagedOrderRemoveItemShippingAddressAction))]
    public partial interface IStagedOrderRemoveItemShippingAddressAction : IStagedOrderUpdateAction
    {
        string AddressKey { get; set; }
    }
}
