using commercetools.Sdk.Api.Models.BusinessUnits;
using commercetools.Sdk.Api.Models.Carts;
using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.CustomerGroups;
using commercetools.Sdk.Api.Models.Customers;
using commercetools.Sdk.Api.Models.Orders;
using commercetools.Sdk.Api.Models.States;
using commercetools.Sdk.Api.Models.Stores;
using commercetools.Sdk.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;


namespace commercetools.Sdk.Api.Models.QuoteRequests
{

    public partial class QuoteRequest : IQuoteRequest
    {
        public string Id { get; set; }

        public long Version { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime LastModifiedAt { get; set; }

        public string Key { get; set; }

        public ILastModifiedBy LastModifiedBy { get; set; }

        public ICreatedBy CreatedBy { get; set; }

        public IQuoteRequestState QuoteRequestState { get; set; }

        public string Comment { get; set; }

        public ICustomerReference Customer { get; set; }

        public ICustomerGroupReference CustomerGroup { get; set; }

        public IStoreKeyReference Store { get; set; }

        public IList<ILineItem> LineItems { get; set; }
        public IEnumerable<ILineItem> LineItemsEnumerable { set => LineItems = value.ToList(); }


        public IList<ICustomLineItem> CustomLineItems { get; set; }
        public IEnumerable<ICustomLineItem> CustomLineItemsEnumerable { set => CustomLineItems = value.ToList(); }


        public ITypedMoney TotalPrice { get; set; }

        public ITaxedPrice TaxedPrice { get; set; }

        public IAddress ShippingAddress { get; set; }

        public IAddress BillingAddress { get; set; }

        public IInventoryMode InventoryMode { get; set; }

        public ITaxMode TaxMode { get; set; }

        public IRoundingMode TaxRoundingMode { get; set; }

        public ITaxCalculationMode TaxCalculationMode { get; set; }

        public string Country { get; set; }

        public IShippingInfo ShippingInfo { get; set; }

        public IPaymentInfo PaymentInfo { get; set; }

        public IShippingRateInput ShippingRateInput { get; set; }

        public IList<IAddress> ItemShippingAddresses { get; set; }
        public IEnumerable<IAddress> ItemShippingAddressesEnumerable { set => ItemShippingAddresses = value.ToList(); }


        public IList<IDirectDiscount> DirectDiscounts { get; set; }
        public IEnumerable<IDirectDiscount> DirectDiscountsEnumerable { set => DirectDiscounts = value.ToList(); }


        public ICustomFields Custom { get; set; }

        public IStateReference State { get; set; }

        public string PurchaseOrderNumber { get; set; }

        public ICartReference Cart { get; set; }

        public IBusinessUnitKeyReference BusinessUnit { get; set; }
    }
}
