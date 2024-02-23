using System.Collections.Generic;
using System.Linq;


namespace commercetools.Sdk.Api.Models.Orders
{

    public partial class OrderSearchFilterExpression : IOrderSearchFilterExpression
    {
        public IList<IOrderSearchQueryExpression> Filter { get; set; }
        public IEnumerable<IOrderSearchQueryExpression> FilterEnumerable { set => Filter = value.ToList(); }

    }
}
