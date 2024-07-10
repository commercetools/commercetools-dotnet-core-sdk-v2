using commercetools.Sdk.Api.Models.BusinessUnits;
using commercetools.Sdk.Api.Models.Carts;
using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.CustomerGroups;
using commercetools.Sdk.Api.Models.Customers;
using commercetools.Sdk.Api.Models.Orders;
using commercetools.Sdk.Api.Models.QuoteRequests;
using commercetools.Sdk.Api.Models.StagedQuotes;
using commercetools.Sdk.Api.Models.States;
using commercetools.Sdk.Api.Models.Stores;
using commercetools.Sdk.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Quotes
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Quotes.Quote))]
    public partial interface IQuote : IBaseResource
    {
        new string Id { get; set; }

        new long Version { get; set; }

        string Key { get; set; }

        new DateTime CreatedAt { get; set; }

        new DateTime LastModifiedAt { get; set; }

        ILastModifiedBy LastModifiedBy { get; set; }

        ICreatedBy CreatedBy { get; set; }

        IQuoteRequestReference QuoteRequest { get; set; }

        IStagedQuoteReference StagedQuote { get; set; }

        ICustomerReference Customer { get; set; }

        ICustomerGroupReference CustomerGroup { get; set; }

        DateTime? ValidTo { get; set; }

        string SellerComment { get; set; }

        string BuyerComment { get; set; }

        IStoreKeyReference Store { get; set; }

        IList<ILineItem> LineItems { get; set; }
        IEnumerable<ILineItem> LineItemsEnumerable { set => LineItems = value.ToList(); }


        IList<ICustomLineItem> CustomLineItems { get; set; }
        IEnumerable<ICustomLineItem> CustomLineItemsEnumerable { set => CustomLineItems = value.ToList(); }


        ITypedMoney TotalPrice { get; set; }

        ITaxedPrice TaxedPrice { get; set; }

        IAddress ShippingAddress { get; set; }

        IAddress BillingAddress { get; set; }

        IInventoryMode InventoryMode { get; set; }

        ITaxMode TaxMode { get; set; }

        IRoundingMode TaxRoundingMode { get; set; }

        ITaxCalculationMode TaxCalculationMode { get; set; }

        string Country { get; set; }

        IShippingInfo ShippingInfo { get; set; }

        IPaymentInfo PaymentInfo { get; set; }

        IShippingRateInput ShippingRateInput { get; set; }

        IList<IAddress> ItemShippingAddresses { get; set; }
        IEnumerable<IAddress> ItemShippingAddressesEnumerable { set => ItemShippingAddresses = value.ToList(); }


        IList<IDirectDiscount> DirectDiscounts { get; set; }
        IEnumerable<IDirectDiscount> DirectDiscountsEnumerable { set => DirectDiscounts = value.ToList(); }


        ICustomFields Custom { get; set; }

        IQuoteState QuoteState { get; set; }

        IStateReference State { get; set; }

        string PurchaseOrderNumber { get; set; }

        IBusinessUnitKeyReference BusinessUnit { get; set; }

    }
}
