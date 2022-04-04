using commercetools.Sdk.Api.Models.Carts;
using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.ShippingMethods;
using commercetools.Sdk.Api.Models.TaxCategories;
using System.Collections.Generic;


namespace commercetools.Sdk.Api.Models.Orders
{
    public partial class ShippingInfoImportDraft : IShippingInfoImportDraft
    {
        public string ShippingMethodName { get; set; }

        public IMoney Price { get; set; }

        public IShippingRateDraft ShippingRate { get; set; }

        public ITaxRate TaxRate { get; set; }

        public ITaxCategoryResourceIdentifier TaxCategory { get; set; }

        public IShippingMethodResourceIdentifier ShippingMethod { get; set; }

        public List<IDelivery> Deliveries { get; set; }

        public IDiscountedLineItemPriceDraft DiscountedPrice { get; set; }

        public IShippingMethodState ShippingMethodState { get; set; }
    }
}
