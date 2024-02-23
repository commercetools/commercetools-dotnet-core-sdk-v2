using commercetools.Sdk.Api.Models.BusinessUnits;
using commercetools.Sdk.Api.Models.Carts;
using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Customers;
using commercetools.Sdk.Api.Models.QuoteRequests;
using commercetools.Sdk.Api.Models.States;
using commercetools.Sdk.Api.Models.Types;
using System;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.StagedQuotes
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.StagedQuotes.StagedQuote))]
    public partial interface IStagedQuote : IBaseResource
    {
        new string Id { get; set; }

        new long Version { get; set; }

        string Key { get; set; }

        new DateTime CreatedAt { get; set; }

        new DateTime LastModifiedAt { get; set; }

        ILastModifiedBy LastModifiedBy { get; set; }

        ICreatedBy CreatedBy { get; set; }

        IStagedQuoteState StagedQuoteState { get; set; }

        ICustomerReference Customer { get; set; }

        IQuoteRequestReference QuoteRequest { get; set; }

        ICartReference QuotationCart { get; set; }

        DateTime? ValidTo { get; set; }

        string SellerComment { get; set; }

        ICustomFields Custom { get; set; }

        IStateReference State { get; set; }

        string PurchaseOrderNumber { get; set; }

        IBusinessUnitKeyReference BusinessUnit { get; set; }

    }
}
