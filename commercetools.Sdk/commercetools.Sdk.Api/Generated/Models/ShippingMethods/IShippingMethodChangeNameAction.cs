using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ShippingMethods
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ShippingMethods.ShippingMethodChangeNameAction))]
    public partial interface IShippingMethodChangeNameAction : IShippingMethodUpdateAction
    {
        string Name { get; set; }

    }
}
