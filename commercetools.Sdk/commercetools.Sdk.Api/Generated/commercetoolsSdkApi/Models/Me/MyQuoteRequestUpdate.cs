using System.Collections.Generic;
using System.Linq;


namespace commercetools.Sdk.Api.Models.Me
{

    public partial class MyQuoteRequestUpdate : IMyQuoteRequestUpdate
    {
        public long Version { get; set; }

        public IList<IMyQuoteRequestUpdateAction> Actions { get; set; }
        public IEnumerable<IMyQuoteRequestUpdateAction> ActionsEnumerable { set => Actions = value.ToList(); }

    }
}
