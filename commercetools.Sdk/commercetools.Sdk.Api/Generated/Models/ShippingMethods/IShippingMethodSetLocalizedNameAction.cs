using commercetools.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ShippingMethods
{
    [DeserializeAs(typeof(commercetools.Api.Models.ShippingMethods.ShippingMethodSetLocalizedNameAction))]
    public partial interface IShippingMethodSetLocalizedNameAction : IShippingMethodUpdateAction
    {
        ILocalizedString LocalizedName { get; set; }
    }
}
