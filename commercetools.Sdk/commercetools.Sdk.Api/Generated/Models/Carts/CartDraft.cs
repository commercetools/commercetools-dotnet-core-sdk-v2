using commercetools.Api.Models.Common;
using commercetools.Api.Models.CustomerGroups;
using commercetools.Api.Models.ShippingMethods;
using commercetools.Api.Models.Stores;
using commercetools.Api.Models.Types;
using System.Collections.Generic;


namespace commercetools.Api.Models.Carts
{
    public partial class CartDraft : ICartDraft
    {
        public string Currency { get; set; }

        public string Key { get; set; }

        public string CustomerId { get; set; }

        public string CustomerEmail { get; set; }

        public ICustomerGroupResourceIdentifier CustomerGroup { get; set; }

        public string AnonymousId { get; set; }

        public IStoreResourceIdentifier Store { get; set; }

        public string Country { get; set; }

        public IInventoryMode InventoryMode { get; set; }

        public ITaxMode TaxMode { get; set; }

        public IRoundingMode TaxRoundingMode { get; set; }

        public ITaxCalculationMode TaxCalculationMode { get; set; }

        public List<ILineItemDraft> LineItems { get; set; }

        public List<ICustomLineItemDraft> CustomLineItems { get; set; }

        public IBaseAddress ShippingAddress { get; set; }

        public IBaseAddress BillingAddress { get; set; }

        public IShippingMethodResourceIdentifier ShippingMethod { get; set; }

        public IExternalTaxRateDraft ExternalTaxRateForShippingMethod { get; set; }

        public ICustomFieldsDraft Custom { get; set; }

        public string Locale { get; set; }

        public long? DeleteDaysAfterLastModification { get; set; }

        public ICartOrigin Origin { get; set; }

        public IShippingRateInputDraft ShippingRateInput { get; set; }

        public List<IBaseAddress> ItemShippingAddresses { get; set; }

        public List<string> DiscountCodes { get; set; }
    }
}
