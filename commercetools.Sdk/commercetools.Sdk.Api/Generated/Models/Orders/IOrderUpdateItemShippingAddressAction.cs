using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Orders.OrderUpdateItemShippingAddressAction))]
    public partial interface IOrderUpdateItemShippingAddressAction : IOrderUpdateAction
    {
        IBaseAddress Address { get; set; }

    }
}
