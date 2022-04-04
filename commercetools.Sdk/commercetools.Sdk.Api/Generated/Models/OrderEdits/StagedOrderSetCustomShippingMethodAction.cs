using commercetools.Sdk.Api.Models.Carts;
using commercetools.Sdk.Api.Models.ShippingMethods;
using commercetools.Sdk.Api.Models.TaxCategories;


namespace commercetools.Sdk.Api.Models.OrderEdits
{
    public partial class StagedOrderSetCustomShippingMethodAction : IStagedOrderSetCustomShippingMethodAction
    {
        public string Action { get; set; }

        public string ShippingMethodName { get; set; }

        public IShippingRateDraft ShippingRate { get; set; }

        public ITaxCategoryResourceIdentifier TaxCategory { get; set; }

        public IExternalTaxRateDraft ExternalTaxRate { get; set; }
        public StagedOrderSetCustomShippingMethodAction()
        {
            this.Action = "setCustomShippingMethod";
        }
    }
}
