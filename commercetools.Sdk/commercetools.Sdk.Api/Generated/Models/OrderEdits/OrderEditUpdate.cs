using System.Collections.Generic;
using System.Linq;


namespace commercetools.Sdk.Api.Models.OrderEdits
{

    public partial class OrderEditUpdate : IOrderEditUpdate
    {
        public long Version { get; set; }

        public IList<IOrderEditUpdateAction> Actions { get; set; }
        public IEnumerable<IOrderEditUpdateAction> ActionsEnumerable { set => Actions = value.ToList(); }


        public bool? DryRun { get; set; }
    }
}
