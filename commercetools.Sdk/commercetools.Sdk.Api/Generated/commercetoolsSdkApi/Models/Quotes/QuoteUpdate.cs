using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.Api.Models.Quotes
{

    public partial class QuoteUpdate : IQuoteUpdate
    {
        public long Version { get; set; }

        public IList<IQuoteUpdateAction> Actions { get; set; }

        public IEnumerable<IQuoteUpdateAction> ActionsEnumerable { set => Actions = value.ToList(); }
    }
}
