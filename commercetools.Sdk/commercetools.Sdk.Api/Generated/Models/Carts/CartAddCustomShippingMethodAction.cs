using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Orders;
using commercetools.Sdk.Api.Models.ShippingMethods;
using commercetools.Sdk.Api.Models.TaxCategories;
using System.Collections.Generic;


namespace commercetools.Sdk.Api.Models.Carts
{

    public partial class CartAddCustomShippingMethodAction : ICartAddCustomShippingMethodAction
    {
        public string Action { get; set; }

        public string ShippingKey { get; set; }

        public string ShippingMethodName { get; set; }

        public IBaseAddress ShippingAddress { get; set; }

        public IShippingRateDraft ShippingRate { get; set; }

        public IShippingRateInputDraft ShippingRateInput { get; set; }

        public ITaxCategoryResourceIdentifier TaxCategory { get; set; }

        public string ExternalTaxRate { get; set; }

        public List<IDelivery> Deliveries { get; set; }

        public string Custom { get; set; }
        public CartAddCustomShippingMethodAction()
        {
            this.Action = "addCustomShippingMethod";
        }
    }
}
