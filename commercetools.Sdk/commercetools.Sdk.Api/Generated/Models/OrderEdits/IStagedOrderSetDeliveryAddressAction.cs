using commercetools.Api.Models.Common;
using commercetools.Api.Models.Orders;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    [DeserializeAs(typeof(commercetools.Api.Models.OrderEdits.StagedOrderSetDeliveryAddressAction))]
    public partial interface IStagedOrderSetDeliveryAddressAction : IStagedOrderUpdateAction
    {
        string DeliveryId { get; set; }

        IBaseAddress Address { get; set; }
    }
}
