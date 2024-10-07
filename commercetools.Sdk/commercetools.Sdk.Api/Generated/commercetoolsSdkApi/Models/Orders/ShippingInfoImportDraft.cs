using commercetools.Sdk.Api.Models.Carts;
using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.ShippingMethods;
using commercetools.Sdk.Api.Models.TaxCategories;
using System.Collections.Generic;
using System.Linq;

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

        public IList<IDeliveryDraft> Deliveries { get; set; }

        public IEnumerable<IDeliveryDraft> DeliveriesEnumerable { set => Deliveries = value.ToList(); }

        public IDiscountedLineItemPriceDraft DiscountedPrice { get; set; }

        public IShippingMethodState ShippingMethodState { get; set; }
    }
}
