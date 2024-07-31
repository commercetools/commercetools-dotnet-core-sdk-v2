using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.ImportApi.Models.Orders
{

    public partial class ItemShippingDetailsDraft : IItemShippingDetailsDraft
    {
        public IList<IItemShippingTarget> Targets { get; set; }

        public IEnumerable<IItemShippingTarget> TargetsEnumerable { set => Targets = value.ToList(); }
    }
}
