using commercetools.Sdk.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Orders
{

    public partial class OrderSearchNotExpression : IOrderSearchNotExpression
    {
        public IList<IOrderSearchQuery> Not { get; set; }
        public IEnumerable<IOrderSearchQuery> NotEnumerable { set => Not = value.ToList(); }

    }
}
