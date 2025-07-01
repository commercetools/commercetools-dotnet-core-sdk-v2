using commercetools.Sdk.Api.Models.BusinessUnits;
using commercetools.Sdk.Api.Models.CartDiscounts;
using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.CustomerGroups;
using commercetools.Sdk.Api.Models.Orders;
using commercetools.Sdk.Api.Models.Stores;
using commercetools.Sdk.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.Api.Models.Carts
{

    public partial class Cart : ICart
    {
        public string Id { get; set; }

        public long Version { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime LastModifiedAt { get; set; }

        public string Key { get; set; }

        public string CustomerId { get; set; }

        public string CustomerEmail { get; set; }

        public ICustomerGroupReference CustomerGroup { get; set; }

        public string AnonymousId { get; set; }

        public IBusinessUnitKeyReference BusinessUnit { get; set; }

        public IStoreKeyReference Store { get; set; }

        public IList<ILineItem> LineItems { get; set; }

        public IEnumerable<ILineItem> LineItemsEnumerable { set => LineItems = value.ToList(); }

        public IList<ICustomLineItem> CustomLineItems { get; set; }

        public IEnumerable<ICustomLineItem> CustomLineItemsEnumerable { set => CustomLineItems = value.ToList(); }

        public long? TotalLineItemQuantity { get; set; }

        public ICentPrecisionMoney TotalPrice { get; set; }

        public ITaxedPrice TaxedPrice { get; set; }

        public ITaxedPrice TaxedShippingPrice { get; set; }

        public IDiscountOnTotalPrice DiscountOnTotalPrice { get; set; }

        public ITaxMode TaxMode { get; set; }

        public IRoundingMode PriceRoundingMode { get; set; }

        public IRoundingMode TaxRoundingMode { get; set; }

        public ITaxCalculationMode TaxCalculationMode { get; set; }

        public IInventoryMode InventoryMode { get; set; }

        public ICartState CartState { get; set; }

        public IAddress BillingAddress { get; set; }

        public IAddress ShippingAddress { get; set; }

        public IShippingMode ShippingMode { get; set; }

        public string ShippingKey { get; set; }

        public IShippingInfo ShippingInfo { get; set; }

        public IShippingRateInput ShippingRateInput { get; set; }

        public ICustomFields ShippingCustomFields { get; set; }

        public IList<IShipping> Shipping { get; set; }

        public IEnumerable<IShipping> ShippingEnumerable { set => Shipping = value.ToList(); }

        public IList<IAddress> ItemShippingAddresses { get; set; }

        public IEnumerable<IAddress> ItemShippingAddressesEnumerable { set => ItemShippingAddresses = value.ToList(); }

        public IList<IDiscountCodeInfo> DiscountCodes { get; set; }

        public IEnumerable<IDiscountCodeInfo> DiscountCodesEnumerable { set => DiscountCodes = value.ToList(); }

        public IList<IDirectDiscount> DirectDiscounts { get; set; }

        public IEnumerable<IDirectDiscount> DirectDiscountsEnumerable { set => DirectDiscounts = value.ToList(); }

        public IList<ICartDiscountReference> RefusedGifts { get; set; }

        public IEnumerable<ICartDiscountReference> RefusedGiftsEnumerable { set => RefusedGifts = value.ToList(); }

        public IPaymentInfo PaymentInfo { get; set; }

        public string Country { get; set; }

        public string Locale { get; set; }

        public ICartOrigin Origin { get; set; }

        public ICustomFields Custom { get; set; }

        public IDiscountTypeCombination DiscountTypeCombination { get; set; }

        public int? DeleteDaysAfterLastModification { get; set; }

        public ILastModifiedBy LastModifiedBy { get; set; }

        public ICreatedBy CreatedBy { get; set; }
    }
}
