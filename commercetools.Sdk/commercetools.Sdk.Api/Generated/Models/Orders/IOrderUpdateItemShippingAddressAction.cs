using commercetools.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Api.Models.Orders.OrderUpdateItemShippingAddressAction))]
    public partial interface IOrderUpdateItemShippingAddressAction : IOrderUpdateAction
    {
        IBaseAddress Address { get; set;}
    }
}
