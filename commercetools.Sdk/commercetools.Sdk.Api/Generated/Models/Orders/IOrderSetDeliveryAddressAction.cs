using commercetools.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Api.Models.Orders.OrderSetDeliveryAddressAction))]
    public partial interface IOrderSetDeliveryAddressAction : IOrderUpdateAction
    {
        string DeliveryId { get; set; }

        IBaseAddress Address { get; set; }
    }
}
