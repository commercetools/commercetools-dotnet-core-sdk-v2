using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Quotes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Quotes
{

    public partial class QuoteReference : IQuoteReference
    {
        public IReferenceTypeId TypeId { get; set; }

        public string Id { get; set; }

        public IQuote Obj { get; set; }
        public QuoteReference()
        {
            this.TypeId = IReferenceTypeId.FindEnum("quote");
        }
    }
}
