using commercetools.Sdk.Api.Models.BusinessUnits;
using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.CustomerGroups;
using commercetools.Sdk.Api.Models.ShippingMethods;
using commercetools.Sdk.Api.Models.Stores;
using commercetools.Sdk.Api.Models.Types;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.Api.Models.Carts
{

    public partial class CartDraft : ICartDraft
    {
        public string Currency { get; set; }

        public string Key { get; set; }

        public string CustomerId { get; set; }

        public string CustomerEmail { get; set; }

        public ICustomerGroupResourceIdentifier CustomerGroup { get; set; }

        public string AnonymousId { get; set; }

        public IBusinessUnitResourceIdentifier BusinessUnit { get; set; }

        public IStoreResourceIdentifier Store { get; set; }

        public IList<ILineItemDraft> LineItems { get; set; }

        public IEnumerable<ILineItemDraft> LineItemsEnumerable { set => LineItems = value.ToList(); }

        public IList<ICustomLineItemDraft> CustomLineItems { get; set; }

        public IEnumerable<ICustomLineItemDraft> CustomLineItemsEnumerable { set => CustomLineItems = value.ToList(); }

        public ITaxMode TaxMode { get; set; }

        public IExternalTaxRateDraft ExternalTaxRateForShippingMethod { get; set; }

        public IRoundingMode TaxRoundingMode { get; set; }

        public ITaxCalculationMode TaxCalculationMode { get; set; }

        public IInventoryMode InventoryMode { get; set; }

        public IBaseAddress BillingAddress { get; set; }

        public IBaseAddress ShippingAddress { get; set; }

        public IShippingMethodResourceIdentifier ShippingMethod { get; set; }

        public IShippingRateInputDraft ShippingRateInput { get; set; }

        public IShippingMode ShippingMode { get; set; }

        public IList<ICustomShippingDraft> CustomShipping { get; set; }

        public IEnumerable<ICustomShippingDraft> CustomShippingEnumerable { set => CustomShipping = value.ToList(); }

        public IList<IShippingDraft> Shipping { get; set; }

        public IEnumerable<IShippingDraft> ShippingEnumerable { set => Shipping = value.ToList(); }

        public IList<IBaseAddress> ItemShippingAddresses { get; set; }

        public IEnumerable<IBaseAddress> ItemShippingAddressesEnumerable { set => ItemShippingAddresses = value.ToList(); }

        public IList<string> DiscountCodes { get; set; }

        public IEnumerable<string> DiscountCodesEnumerable { set => DiscountCodes = value.ToList(); }

        public string Country { get; set; }

        public string Locale { get; set; }

        public ICartOrigin Origin { get; set; }

        public long? DeleteDaysAfterLastModification { get; set; }

        public ICustomFieldsDraft Custom { get; set; }
    }
}
