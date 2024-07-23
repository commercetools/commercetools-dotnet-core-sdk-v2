using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ShippingMethods
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ShippingMethods.ShippingMethodSetDescriptionAction))]
    public partial interface IShippingMethodSetDescriptionAction : IShippingMethodUpdateAction
    {
        string Description { get; set; }

    }
}
