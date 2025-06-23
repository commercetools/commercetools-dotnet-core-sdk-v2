using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.Api.Models.DiscountGroups
{

    public partial class DiscountGroupUpdate : IDiscountGroupUpdate
    {
        public long Version { get; set; }

        public IList<IDiscountGroupUpdateAction> Actions { get; set; }

        public IEnumerable<IDiscountGroupUpdateAction> ActionsEnumerable { set => Actions = value.ToList(); }
    }
}
