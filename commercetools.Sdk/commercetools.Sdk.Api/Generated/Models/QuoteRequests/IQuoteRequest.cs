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
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.QuoteRequests
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.QuoteRequests.QuoteRequest))]
    public partial interface IQuoteRequest : IBaseResource
    {
        new string Id { get; set; }

        new long Version { get; set; }

        string Key { get; set; }

        new DateTime CreatedAt { get; set; }

        new DateTime LastModifiedAt { get; set; }

        ILastModifiedBy LastModifiedBy { get; set; }

        ICreatedBy CreatedBy { get; set; }

        IQuoteRequestState QuoteRequestState { get; set; }

        string Comment { get; set; }

        ICustomerReference Customer { get; set; }

        ICustomerGroupReference CustomerGroup { get; set; }

        IStoreKeyReference Store { get; set; }

        List<ILineItem> LineItems { get; set; }

        List<ICustomLineItem> CustomLineItems { get; set; }

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

        List<IAddress> ItemShippingAddresses { get; set; }

        List<IDirectDiscount> DirectDiscounts { get; set; }

        ICustomFields Custom { get; set; }

        IStateReference State { get; set; }

        IBusinessUnitKeyReference BusinessUnit { get; set; }

    }
}
