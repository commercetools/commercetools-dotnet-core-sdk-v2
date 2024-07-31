using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.Api.Models.Orders
{

    public partial class OrderSearchNotExpression : IOrderSearchNotExpression
    {
        public IList<IOrderSearchQuery> Not { get; set; }

        public IEnumerable<IOrderSearchQuery> NotEnumerable { set => Not = value.ToList(); }
    }
}
