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
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Orders.Order))]
    public partial interface IOrder : IBaseResource
    {
        new string Id { get; set; }

        new long Version { get; set; }

        new DateTime CreatedAt { get; set; }

        new DateTime LastModifiedAt { get; set; }

        ILastModifiedBy LastModifiedBy { get; set; }

        ICreatedBy CreatedBy { get; set; }

        DateTime? CompletedAt { get; set; }

        string OrderNumber { get; set; }

        string CustomerId { get; set; }

        string CustomerEmail { get; set; }

        string AnonymousId { get; set; }

        IBusinessUnitKeyReference BusinessUnit { get; set; }

        IStoreKeyReference Store { get; set; }

        IList<ILineItem> LineItems { get; set; }
        IEnumerable<ILineItem> LineItemsEnumerable { set => LineItems = value.ToList(); }


        IList<ICustomLineItem> CustomLineItems { get; set; }
        IEnumerable<ICustomLineItem> CustomLineItemsEnumerable { set => CustomLineItems = value.ToList(); }


        ITypedMoney TotalPrice { get; set; }

        ITaxedPrice TaxedPrice { get; set; }

        ITaxedPrice TaxedShippingPrice { get; set; }

        IAddress ShippingAddress { get; set; }

        IAddress BillingAddress { get; set; }

        IShippingMode ShippingMode { get; set; }

        string ShippingKey { get; set; }

        ICustomFields ShippingCustomFields { get; set; }

        IList<IShipping> Shipping { get; set; }
        IEnumerable<IShipping> ShippingEnumerable { set => Shipping = value.ToList(); }


        ITaxMode TaxMode { get; set; }

        IRoundingMode TaxRoundingMode { get; set; }

        ICustomerGroupReference CustomerGroup { get; set; }

        string Country { get; set; }

        IOrderState OrderState { get; set; }

        IStateReference State { get; set; }

        IShipmentState ShipmentState { get; set; }

        IPaymentState PaymentState { get; set; }

        IShippingInfo ShippingInfo { get; set; }

        IList<ISyncInfo> SyncInfo { get; set; }
        IEnumerable<ISyncInfo> SyncInfoEnumerable { set => SyncInfo = value.ToList(); }


        IList<IReturnInfo> ReturnInfo { get; set; }
        IEnumerable<IReturnInfo> ReturnInfoEnumerable { set => ReturnInfo = value.ToList(); }


        string PurchaseOrderNumber { get; set; }

        IList<IDiscountCodeInfo> DiscountCodes { get; set; }
        IEnumerable<IDiscountCodeInfo> DiscountCodesEnumerable { set => DiscountCodes = value.ToList(); }


        [ObsoleteAttribute("This property is obsolete", false)]
        long? LastMessageSequenceNumber { get; set; }

        ICartReference Cart { get; set; }

        IQuoteReference Quote { get; set; }

        ICustomFields Custom { get; set; }

        IPaymentInfo PaymentInfo { get; set; }

        string Locale { get; set; }

        IInventoryMode InventoryMode { get; set; }

        ICartOrigin Origin { get; set; }

        ITaxCalculationMode TaxCalculationMode { get; set; }

        IShippingRateInput ShippingRateInput { get; set; }

        IList<IAddress> ItemShippingAddresses { get; set; }
        IEnumerable<IAddress> ItemShippingAddressesEnumerable { set => ItemShippingAddresses = value.ToList(); }


        IList<ICartDiscountReference> RefusedGifts { get; set; }
        IEnumerable<ICartDiscountReference> RefusedGiftsEnumerable { set => RefusedGifts = value.ToList(); }


    }
}
