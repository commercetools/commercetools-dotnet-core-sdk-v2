using commercetools.Sdk.Api.Models.Common;


namespace commercetools.Sdk.Api.Models.ShippingMethods
{

    public partial class ShippingMethodSetLocalizedDescriptionAction : IShippingMethodSetLocalizedDescriptionAction
    {
        public string Action { get; set; }

        public ILocalizedString LocalizedDescription { get; set; }
        public ShippingMethodSetLocalizedDescriptionAction()
        {
            this.Action = "setLocalizedDescription";
        }
    }
}
