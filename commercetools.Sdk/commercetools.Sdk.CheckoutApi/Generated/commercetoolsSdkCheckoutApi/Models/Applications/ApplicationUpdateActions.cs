using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.CheckoutApi.Models.Applications
{

    public partial class ApplicationUpdateActions : IApplicationUpdateActions
    {
        public int Version { get; set; }

        public IList<IApplicationUpdateAction> Actions { get; set; }

        public IEnumerable<IApplicationUpdateAction> ActionsEnumerable { set => Actions = value.ToList(); }
    }
}
