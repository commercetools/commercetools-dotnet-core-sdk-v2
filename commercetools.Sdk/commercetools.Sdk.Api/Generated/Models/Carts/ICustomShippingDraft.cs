using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Orders;
using commercetools.Sdk.Api.Models.ShippingMethods;
using commercetools.Sdk.Api.Models.TaxCategories;
using commercetools.Sdk.Api.Models.Types;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Carts.CustomShippingDraft))]
    public partial interface ICustomShippingDraft
    {
        string Key { get; set; }

        string ShippingMethodName { get; set; }

        IBaseAddress ShippingAddress { get; set; }

        IShippingRateDraft ShippingRate { get; set; }

        IShippingRateInputDraft ShippingRateInput { get; set; }

        ITaxCategoryResourceIdentifier TaxCategory { get; set; }

        IExternalTaxRateDraft ExternalTaxRate { get; set; }

        IList<IDeliveryDraft> Deliveries { get; set; }
        IEnumerable<IDeliveryDraft> DeliveriesEnumerable { set => Deliveries = value.ToList(); }


        ICustomFieldsDraft Custom { get; set; }

    }
}
