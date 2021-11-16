using commercetools.Api.Models.Carts;
using commercetools.Api.Models.ShippingMethods;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Me
{
    [DeserializeAs(typeof(commercetools.Api.Models.Me.MyCartSetShippingMethodAction))]
    public partial interface IMyCartSetShippingMethodAction : IMyCartUpdateAction
    {
        IShippingMethodResourceIdentifier ShippingMethod { get; set;}
        
        IExternalTaxRateDraft ExternalTaxRate { get; set;}
    }
}
