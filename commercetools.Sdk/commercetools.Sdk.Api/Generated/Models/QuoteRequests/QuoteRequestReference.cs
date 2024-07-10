using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.QuoteRequests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.QuoteRequests
{

    public partial class QuoteRequestReference : IQuoteRequestReference
    {
        public IReferenceTypeId TypeId { get; set; }

        public string Id { get; set; }

        public IQuoteRequest Obj { get; set; }
        public QuoteRequestReference()
        {
            this.TypeId = IReferenceTypeId.FindEnum("quote-request");
        }
    }
}
