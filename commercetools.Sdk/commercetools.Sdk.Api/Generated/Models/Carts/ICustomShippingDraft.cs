using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Orders;
using commercetools.Sdk.Api.Models.ShippingMethods;
using commercetools.Sdk.Api.Models.TaxCategories;
using System.Collections.Generic;
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

        string ExternalTaxRate { get; set; }

        List<IDelivery> Deliveries { get; set; }

        string Custom { get; set; }

    }
}
