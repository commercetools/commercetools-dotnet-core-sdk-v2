using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Orders.OrderSetDeliveryAddressAction))]
    public partial interface IOrderSetDeliveryAddressAction : IOrderUpdateAction
    {
        string DeliveryId { get; set; }

        string DeliveryKey { get; set; }

        IBaseAddress Address { get; set; }

    }
}
