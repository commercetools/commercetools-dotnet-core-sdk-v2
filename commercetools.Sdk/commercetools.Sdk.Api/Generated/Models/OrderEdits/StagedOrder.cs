using commercetools.Sdk.Api.Models.BusinessUnits;
using commercetools.Sdk.Api.Models.CartDiscounts;
using commercetools.Sdk.Api.Models.Carts;
using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.CustomerGroups;
using commercetools.Sdk.Api.Models.Orders;
using commercetools.Sdk.Api.Models.Quotes;
using commercetools.Sdk.Api.Models.States;
using commercetools.Sdk.Api.Models.Stores;
using commercetools.Sdk.Api.Models.Types;
using System;
using System.Collections.Generic;


namespace commercetools.Sdk.Api.Models.OrderEdits
{

    public partial class StagedOrder : IStagedOrder
    {
        public string Id { get; set; }

        public long Version { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime LastModifiedAt { get; set; }

        public ILastModifiedBy LastModifiedBy { get; set; }

        public ICreatedBy CreatedBy { get; set; }

        public DateTime? CompletedAt { get; set; }

        public string OrderNumber { get; set; }

        public string CustomerId { get; set; }

        public string CustomerEmail { get; set; }

        public string AnonymousId { get; set; }

        public IBusinessUnitKeyReference BusinessUnit { get; set; }

        public IStoreKeyReference Store { get; set; }

        public List<ILineItem> LineItems { get; set; }

        public List<ICustomLineItem> CustomLineItems { get; set; }

        public ITypedMoney TotalPrice { get; set; }

        public ITaxedPrice TaxedPrice { get; set; }

        public ITaxedPrice TaxedShippingPrice { get; set; }

        public IAddress ShippingAddress { get; set; }

        public IAddress BillingAddress { get; set; }

        public IShippingMode ShippingMode { get; set; }

        public List<IShipping> Shipping { get; set; }

        public ITaxMode TaxMode { get; set; }

        public IRoundingMode TaxRoundingMode { get; set; }

        public ICustomerGroupReference CustomerGroup { get; set; }

        public string Country { get; set; }

        public IOrderState OrderState { get; set; }

        public IStateReference State { get; set; }

        public IShipmentState ShipmentState { get; set; }

        public IPaymentState PaymentState { get; set; }

        public IShippingInfo ShippingInfo { get; set; }

        public List<ISyncInfo> SyncInfo { get; set; }

        public List<IReturnInfo> ReturnInfo { get; set; }

        public List<IDiscountCodeInfo> DiscountCodes { get; set; }

        [ObsoleteAttribute("This property is obsolete", false)]
        public long? LastMessageSequenceNumber { get; set; }

        public ICartReference Cart { get; set; }

        public IQuoteReference Quote { get; set; }

        public ICustomFields Custom { get; set; }

        public IPaymentInfo PaymentInfo { get; set; }

        public string Locale { get; set; }

        public IInventoryMode InventoryMode { get; set; }

        public ICartOrigin Origin { get; set; }

        public ITaxCalculationMode TaxCalculationMode { get; set; }

        public IShippingRateInput ShippingRateInput { get; set; }

        public List<IAddress> ItemShippingAddresses { get; set; }

        public List<ICartDiscountReference> RefusedGifts { get; set; }
    }
}
