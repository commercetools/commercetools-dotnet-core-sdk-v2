using commercetools.Sdk.Api.Models.Carts;
using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Customers;
using commercetools.Sdk.Api.Models.QuoteRequests;
using commercetools.Sdk.Api.Models.Types;
using System;


namespace commercetools.Sdk.Api.Models.StagedQuotes
{

    public partial class StagedQuote : IStagedQuote
    {
        public string Id { get; set; }

        public long Version { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime LastModifiedAt { get; set; }

        public string Key { get; set; }

        public ILastModifiedBy LastModifiedBy { get; set; }

        public ICreatedBy CreatedBy { get; set; }

        public IStagedQuoteState StagedQuoteState { get; set; }

        public ICustomerReference Customer { get; set; }

        public IQuoteRequestReference QuoteRequest { get; set; }

        public ICartReference QuotationCart { get; set; }

        public DateTime? ValidTo { get; set; }

        public string SellerComment { get; set; }

        public ICustomFields Custom { get; set; }
    }
}
