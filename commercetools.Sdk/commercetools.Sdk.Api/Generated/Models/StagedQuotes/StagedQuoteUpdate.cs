using commercetools.Sdk.Api.Models.StagedQuotes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.StagedQuotes
{

    public partial class StagedQuoteUpdate : IStagedQuoteUpdate
    {
        public long Version { get; set; }

        public IList<IStagedQuoteUpdateAction> Actions { get; set; }
        public IEnumerable<IStagedQuoteUpdateAction> ActionsEnumerable { set => Actions = value.ToList(); }

    }
}
