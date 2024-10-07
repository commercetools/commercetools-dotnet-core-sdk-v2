using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Orders.OrderSetShippingAddressAction))]
    public partial interface IOrderSetShippingAddressAction : IOrderUpdateAction
    {
        IBaseAddress Address { get; set; }

    }
}
