using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.Api.Models.Me
{

    public partial class MyPaymentUpdate : IMyPaymentUpdate
    {
        public long Version { get; set; }

        public IList<IMyPaymentUpdateAction> Actions { get; set; }

        public IEnumerable<IMyPaymentUpdateAction> ActionsEnumerable { set => Actions = value.ToList(); }
    }
}
