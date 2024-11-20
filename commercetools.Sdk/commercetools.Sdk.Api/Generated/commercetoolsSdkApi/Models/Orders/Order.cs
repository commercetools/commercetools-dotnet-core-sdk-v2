using commercetools.Sdk.Api.Models.BusinessUnits;
using commercetools.Sdk.Api.Models.CartDiscounts;
using commercetools.Sdk.Api.Models.Carts;
using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.CustomerGroups;
using commercetools.Sdk.Api.Models.Quotes;
using commercetools.Sdk.Api.Models.States;
using commercetools.Sdk.Api.Models.Stores;
using commercetools.Sdk.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.Api.Models.Orders
{

    public partial class Order : IOrder
    {
        public string Id { get; set; }

        public long Version { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime LastModifiedAt { get; set; }

        public string OrderNumber { get; set; }

        public string PurchaseOrderNumber { get; set; }

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

        public ICentPrecisionMoney TotalPrice { get; set; }

        public ITaxedPrice TaxedPrice { get; set; }

        public ITaxedPrice TaxedShippingPrice { get; set; }

        public IDiscountOnTotalPrice DiscountOnTotalPrice { get; set; }

        public ITaxMode TaxMode { get; set; }

        public IRoundingMode TaxRoundingMode { get; set; }

        public ITaxCalculationMode TaxCalculationMode { get; set; }

        public IInventoryMode InventoryMode { get; set; }

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

        public ICartReference Cart { get; set; }

        public IQuoteReference Quote { get; set; }

        public IOrderState OrderState { get; set; }

        public IShipmentState ShipmentState { get; set; }

        public IPaymentState PaymentState { get; set; }

        public IStateReference State { get; set; }

        public IList<ISyncInfo> SyncInfo { get; set; }

        public IEnumerable<ISyncInfo> SyncInfoEnumerable { set => SyncInfo = value.ToList(); }

        public IList<IReturnInfo> ReturnInfo { get; set; }

        public IEnumerable<IReturnInfo> ReturnInfoEnumerable { set => ReturnInfo = value.ToList(); }

        [ObsoleteAttribute("This property is obsolete", false)]
        public long? LastMessageSequenceNumber { get; set; }

        public ICustomFields Custom { get; set; }

        public DateTime? CompletedAt { get; set; }

        public ILastModifiedBy LastModifiedBy { get; set; }

        public ICreatedBy CreatedBy { get; set; }
    }
}
