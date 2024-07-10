using commercetools.Sdk.Api.Models.Carts;
using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Orders;
using commercetools.Sdk.Api.Models.ShippingMethods;
using commercetools.Sdk.Api.Models.TaxCategories;
using commercetools.Sdk.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


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

        public IExternalTaxRateDraft ExternalTaxRate { get; set; }

        public IList<IDeliveryDraft> Deliveries { get; set; }
        public IEnumerable<IDeliveryDraft> DeliveriesEnumerable { set => Deliveries = value.ToList(); }


        public ICustomFieldsDraft Custom { get; set; }
    }
}
