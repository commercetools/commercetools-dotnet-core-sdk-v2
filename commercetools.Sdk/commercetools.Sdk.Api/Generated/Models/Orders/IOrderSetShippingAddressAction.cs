using commercetools.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Api.Models.Orders.OrderSetShippingAddressAction))]
    public partial interface IOrderSetShippingAddressAction : IOrderUpdateAction
    {
        IBaseAddress Address { get; set; }
    }
}
