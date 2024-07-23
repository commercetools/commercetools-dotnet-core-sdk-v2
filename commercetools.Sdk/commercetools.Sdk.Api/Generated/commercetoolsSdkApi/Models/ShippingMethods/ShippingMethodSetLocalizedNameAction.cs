using commercetools.Sdk.Api.Models.Common;


namespace commercetools.Sdk.Api.Models.ShippingMethods
{

    public partial class ShippingMethodSetLocalizedNameAction : IShippingMethodSetLocalizedNameAction
    {
        public string Action { get; set; }

        public ILocalizedString LocalizedName { get; set; }
        public ShippingMethodSetLocalizedNameAction()
        {
            this.Action = "setLocalizedName";
        }
    }
}
