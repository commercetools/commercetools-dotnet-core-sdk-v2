using System.Collections.Generic;
using System.Linq;


namespace commercetools.Sdk.Api.Models.Common
{

    public partial class Update : IUpdate
    {
        public long Version { get; set; }

        public IList<IUpdateAction> Actions { get; set; }
        public IEnumerable<IUpdateAction> ActionsEnumerable { set => Actions = value.ToList(); }

    }
}
