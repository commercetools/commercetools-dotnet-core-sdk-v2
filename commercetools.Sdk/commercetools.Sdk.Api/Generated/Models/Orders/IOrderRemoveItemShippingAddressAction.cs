using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Orders.OrderRemoveItemShippingAddressAction))]
    public partial interface IOrderRemoveItemShippingAddressAction : IOrderUpdateAction
    {
        string AddressKey { get; set; }

    }
}
