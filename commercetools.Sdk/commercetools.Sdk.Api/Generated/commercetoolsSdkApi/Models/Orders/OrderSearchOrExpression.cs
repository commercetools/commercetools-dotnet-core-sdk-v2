using System.Collections.Generic;
using System.Linq;


namespace commercetools.Sdk.Api.Models.Orders
{

    public partial class OrderSearchOrExpression : IOrderSearchOrExpression
    {
        public IList<IOrderSearchQuery> Or { get; set; }
        public IEnumerable<IOrderSearchQuery> OrEnumerable { set => Or = value.ToList(); }

    }
}
