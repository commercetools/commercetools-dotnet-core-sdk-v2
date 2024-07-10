using commercetools.Sdk.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Orders
{

    public partial class OrderSearchAndExpression : IOrderSearchAndExpression
    {
        public IList<IOrderSearchQuery> And { get; set; }
        public IEnumerable<IOrderSearchQuery> AndEnumerable { set => And = value.ToList(); }

    }
}
