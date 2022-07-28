using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Orders.OrderAddItemShippingAddressAction))]
    public partial interface IOrderAddItemShippingAddressAction : IOrderUpdateAction
    {
        IBaseAddress Address { get; set; }

    }
}
