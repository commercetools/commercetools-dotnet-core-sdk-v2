using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Orders;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.OrderEdits
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.OrderEdits.StagedOrderSetDeliveryAddressAction))]
    public partial interface IStagedOrderSetDeliveryAddressAction : IStagedOrderUpdateAction
    {
        string DeliveryId { get; set; }

        IBaseAddress Address { get; set; }
    }
}
