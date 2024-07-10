using commercetools.Sdk.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Orders
{

    public partial class OrderSearchOrExpression : IOrderSearchOrExpression
    {
        public IList<IOrderSearchQuery> Or { get; set; }
        public IEnumerable<IOrderSearchQuery> OrEnumerable { set => Or = value.ToList(); }

    }
}
