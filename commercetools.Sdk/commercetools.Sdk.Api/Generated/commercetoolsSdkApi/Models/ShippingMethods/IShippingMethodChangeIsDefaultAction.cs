using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ShippingMethods
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ShippingMethods.ShippingMethodChangeIsDefaultAction))]
    public partial interface IShippingMethodChangeIsDefaultAction : IShippingMethodUpdateAction
    {
        bool IsDefault { get; set; }

    }
}
