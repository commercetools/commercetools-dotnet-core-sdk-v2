using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.StagedQuotes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.StagedQuotes
{

    public partial class StagedQuoteReference : IStagedQuoteReference
    {
        public IReferenceTypeId TypeId { get; set; }

        public string Id { get; set; }

        public IStagedQuote Obj { get; set; }
        public StagedQuoteReference()
        {
            this.TypeId = IReferenceTypeId.FindEnum("staged-quote");
        }
    }
}
