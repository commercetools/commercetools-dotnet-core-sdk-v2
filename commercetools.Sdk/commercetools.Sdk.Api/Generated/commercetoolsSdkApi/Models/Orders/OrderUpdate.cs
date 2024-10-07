using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.Api.Models.Orders
{

    public partial class OrderUpdate : IOrderUpdate
    {
        public long Version { get; set; }

        public IList<IOrderUpdateAction> Actions { get; set; }

        public IEnumerable<IOrderUpdateAction> ActionsEnumerable { set => Actions = value.ToList(); }
    }
}
