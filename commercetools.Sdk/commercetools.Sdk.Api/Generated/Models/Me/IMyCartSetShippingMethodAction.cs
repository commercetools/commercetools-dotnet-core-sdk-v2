using commercetools.Sdk.Api.Models.Carts;
using commercetools.Sdk.Api.Models.ShippingMethods;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Me
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Me.MyCartSetShippingMethodAction))]
    public partial interface IMyCartSetShippingMethodAction : IMyCartUpdateAction
    {
        IShippingMethodResourceIdentifier ShippingMethod { get; set; }

        IExternalTaxRateDraft ExternalTaxRate { get; set; }

    }
}
