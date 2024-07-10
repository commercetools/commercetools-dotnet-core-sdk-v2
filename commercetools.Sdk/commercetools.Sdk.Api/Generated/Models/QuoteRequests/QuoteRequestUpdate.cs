using commercetools.Sdk.Api.Models.QuoteRequests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.QuoteRequests
{

    public partial class QuoteRequestUpdate : IQuoteRequestUpdate
    {
        public long Version { get; set; }

        public IList<IQuoteRequestUpdateAction> Actions { get; set; }
        public IEnumerable<IQuoteRequestUpdateAction> ActionsEnumerable { set => Actions = value.ToList(); }

    }
}
