using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Orders;
using commercetools.Sdk.Api.Models.ShippingMethods;
using commercetools.Sdk.Api.Models.TaxCategories;
using System.Collections.Generic;
using System.Linq;


namespace commercetools.Sdk.Api.Models.Carts
{

    public partial class CustomShippingDraft : ICustomShippingDraft
    {
        public string Key { get; set; }

        public string ShippingMethodName { get; set; }

        public IBaseAddress ShippingAddress { get; set; }

        public IShippingRateDraft ShippingRate { get; set; }

        public IShippingRateInputDraft ShippingRateInput { get; set; }

        public ITaxCategoryResourceIdentifier TaxCategory { get; set; }

        public string ExternalTaxRate { get; set; }

        public IList<IDelivery> Deliveries { get; set; }
        public IEnumerable<IDelivery> DeliveriesEnumerable { set => Deliveries = value.ToList(); }


        public string Custom { get; set; }
    }
}
