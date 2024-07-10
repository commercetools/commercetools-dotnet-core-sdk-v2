using System.Collections.Generic;
using System.Linq;


namespace commercetools.Sdk.Api.Models.StagedQuotes
{

    public partial class StagedQuoteUpdate : IStagedQuoteUpdate
    {
        public long Version { get; set; }

        public IList<IStagedQuoteUpdateAction> Actions { get; set; }
        public IEnumerable<IStagedQuoteUpdateAction> ActionsEnumerable { set => Actions = value.ToList(); }

    }
}
