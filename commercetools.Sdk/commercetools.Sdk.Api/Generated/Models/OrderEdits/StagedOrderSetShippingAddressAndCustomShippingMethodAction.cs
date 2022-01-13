using commercetools.Api.Models.Carts;
using commercetools.Api.Models.Common;
using commercetools.Api.Models.ShippingMethods;
using commercetools.Api.Models.TaxCategories;


namespace commercetools.Api.Models.OrderEdits
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
