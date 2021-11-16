using commercetools.Api.Models.Common;


namespace commercetools.Api.Models.ShippingMethods
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
