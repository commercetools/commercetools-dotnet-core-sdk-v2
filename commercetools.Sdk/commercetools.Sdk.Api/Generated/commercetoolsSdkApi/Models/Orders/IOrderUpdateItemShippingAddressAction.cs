using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Orders.OrderUpdateItemShippingAddressAction))]
    public partial interface IOrderUpdateItemShippingAddressAction : IOrderUpdateAction
    {
        IBaseAddress Address { get; set; }

    }
}
