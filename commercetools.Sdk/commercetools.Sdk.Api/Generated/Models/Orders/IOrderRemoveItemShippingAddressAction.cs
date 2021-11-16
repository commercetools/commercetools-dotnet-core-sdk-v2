using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Api.Models.Orders.OrderRemoveItemShippingAddressAction))]
    public partial interface IOrderRemoveItemShippingAddressAction : IOrderUpdateAction
    {
        string AddressKey { get; set;}
    }
}
