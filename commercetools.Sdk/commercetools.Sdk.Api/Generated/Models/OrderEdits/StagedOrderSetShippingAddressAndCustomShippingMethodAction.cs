using commercetools.Sdk.Api.Models.Carts;
using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.ShippingMethods;
using commercetools.Sdk.Api.Models.TaxCategories;


namespace commercetools.Sdk.Api.Models.OrderEdits
{

    public partial class StagedOrderSetShippingAddressAndCustomShippingMethodAction : IStagedOrderSetShippingAddressAndCustomShippingMethodAction
    {
        public string Action { get; set; }

        public IBaseAddress Address { get; set; }

        public string ShippingMethodName { get; set; }

        public IShippingRateDraft ShippingRate { get; set; }

        public ITaxCategoryResourceIdentifier TaxCategory { get; set; }

        public IExternalTaxRateDraft ExternalTaxRate { get; set; }
        public StagedOrderSetShippingAddressAndCustomShippingMethodAction()
        {
            this.Action = "setShippingAddressAndCustomShippingMethod";
        }
    }
}
