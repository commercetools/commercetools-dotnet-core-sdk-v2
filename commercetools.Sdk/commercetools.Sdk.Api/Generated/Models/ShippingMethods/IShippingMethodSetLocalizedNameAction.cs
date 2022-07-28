using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.ShippingMethods
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ShippingMethods.ShippingMethodSetLocalizedNameAction))]
    public partial interface IShippingMethodSetLocalizedNameAction : IShippingMethodUpdateAction
    {
        ILocalizedString LocalizedName { get; set; }

    }
}
