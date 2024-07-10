using commercetools.Sdk.Api.Models.Quotes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Quotes
{

    public partial class QuoteUpdate : IQuoteUpdate
    {
        public long Version { get; set; }

        public IList<IQuoteUpdateAction> Actions { get; set; }
        public IEnumerable<IQuoteUpdateAction> ActionsEnumerable { set => Actions = value.ToList(); }

    }
}
