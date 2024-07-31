using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.Api.Models.Orders
{

    public partial class OrderSearchAndExpression : IOrderSearchAndExpression
    {
        public IList<IOrderSearchQuery> And { get; set; }

        public IEnumerable<IOrderSearchQuery> AndEnumerable { set => And = value.ToList(); }
    }
}
