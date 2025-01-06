using commercetools.Sdk.Api.Models.ShippingMethods;
using commercetools.Sdk.Api.Models.TaxCategories;
using commercetools.Sdk.Api.Models.Types;


namespace commercetools.Sdk.Api.Models.Carts
{

    public partial class CartSetCustomShippingMethodAction : ICartSetCustomShippingMethodAction
    {
        public string Action { get; set; }

        public string ShippingMethodName { get; set; }

        public IShippingRateDraft ShippingRate { get; set; }

        public ITaxCategoryResourceIdentifier TaxCategory { get; set; }

        public IExternalTaxRateDraft ExternalTaxRate { get; set; }

        public ICustomFieldsDraft Custom { get; set; }
        public CartSetCustomShippingMethodAction()
        {
            this.Action = "setCustomShippingMethod";
        }
    }
}
