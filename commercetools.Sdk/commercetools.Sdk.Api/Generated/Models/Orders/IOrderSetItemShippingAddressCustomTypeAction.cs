using commercetools.Sdk.Api.Models.Types;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Orders.OrderSetItemShippingAddressCustomTypeAction))]
    public partial interface IOrderSetItemShippingAddressCustomTypeAction : IOrderUpdateAction
    {
        string AddressKey { get; set; }

        ITypeResourceIdentifier Type { get; set; }

        IFieldContainer Fields { get; set; }

    }
}
