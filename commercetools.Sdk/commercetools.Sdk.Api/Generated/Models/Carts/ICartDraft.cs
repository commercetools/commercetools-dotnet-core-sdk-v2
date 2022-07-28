using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.CustomerGroups;
using commercetools.Sdk.Api.Models.ShippingMethods;
using commercetools.Sdk.Api.Models.Stores;
using commercetools.Sdk.Api.Models.Types;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Carts.CartDraft))]
    public partial interface ICartDraft
    {
        string Currency { get; set; }

        string Key { get; set; }

        string CustomerId { get; set; }

        string CustomerEmail { get; set; }

        ICustomerGroupResourceIdentifier CustomerGroup { get; set; }

        string AnonymousId { get; set; }

        IStoreResourceIdentifier Store { get; set; }

        string Country { get; set; }

        IInventoryMode InventoryMode { get; set; }

        ITaxMode TaxMode { get; set; }

        IRoundingMode TaxRoundingMode { get; set; }

        ITaxCalculationMode TaxCalculationMode { get; set; }

        List<ILineItemDraft> LineItems { get; set; }

        List<ICustomLineItemDraft> CustomLineItems { get; set; }

        IBaseAddress ShippingAddress { get; set; }

        IBaseAddress BillingAddress { get; set; }

        IShippingMethodResourceIdentifier ShippingMethod { get; set; }

        IExternalTaxRateDraft ExternalTaxRateForShippingMethod { get; set; }

        ICustomFieldsDraft Custom { get; set; }

        string Locale { get; set; }

        long? DeleteDaysAfterLastModification { get; set; }

        ICartOrigin Origin { get; set; }

        IShippingRateInputDraft ShippingRateInput { get; set; }

        List<IBaseAddress> ItemShippingAddresses { get; set; }

        List<string> DiscountCodes { get; set; }

    }
}
