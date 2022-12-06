using commercetools.Sdk.Api.Models.BusinessUnits;
using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.CustomerGroups;
using commercetools.Sdk.Api.Models.ShippingMethods;
using commercetools.Sdk.Api.Models.Stores;
using commercetools.Sdk.Api.Models.Types;
using System.Collections.Generic;
using System.Linq;
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

        IBusinessUnitResourceIdentifier BusinessUnit { get; set; }

        IStoreResourceIdentifier Store { get; set; }

        string Country { get; set; }

        IInventoryMode InventoryMode { get; set; }

        ITaxMode TaxMode { get; set; }

        IRoundingMode TaxRoundingMode { get; set; }

        ITaxCalculationMode TaxCalculationMode { get; set; }

        IList<ILineItemDraft> LineItems { get; set; }
        IEnumerable<ILineItemDraft> LineItemsEnumerable { set => LineItems = value.ToList(); }


        IList<ICustomLineItemDraft> CustomLineItems { get; set; }
        IEnumerable<ICustomLineItemDraft> CustomLineItemsEnumerable { set => CustomLineItems = value.ToList(); }


        IBaseAddress ShippingAddress { get; set; }

        IBaseAddress BillingAddress { get; set; }

        IShippingMethodResourceIdentifier ShippingMethod { get; set; }

        IExternalTaxRateDraft ExternalTaxRateForShippingMethod { get; set; }

        ICustomFieldsDraft Custom { get; set; }

        string Locale { get; set; }

        long? DeleteDaysAfterLastModification { get; set; }

        ICartOrigin Origin { get; set; }

        IShippingMode ShippingMode { get; set; }

        IList<ICustomShippingDraft> CustomShipping { get; set; }
        IEnumerable<ICustomShippingDraft> CustomShippingEnumerable { set => CustomShipping = value.ToList(); }


        IList<IShippingDraft> Shipping { get; set; }
        IEnumerable<IShippingDraft> ShippingEnumerable { set => Shipping = value.ToList(); }


        IShippingRateInputDraft ShippingRateInput { get; set; }

        IList<IBaseAddress> ItemShippingAddresses { get; set; }
        IEnumerable<IBaseAddress> ItemShippingAddressesEnumerable { set => ItemShippingAddresses = value.ToList(); }


        IList<string> DiscountCodes { get; set; }
        IEnumerable<string> DiscountCodesEnumerable { set => DiscountCodes = value.ToList(); }


    }
}
