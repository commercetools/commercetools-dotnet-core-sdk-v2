using commercetools.Sdk.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Orders
{

    public partial class OrderSearchRequest : IOrderSearchRequest
    {
        public IOrderSearchQuery Query { get; set; }

        public IList<IOrderSearchSorting> Sort { get; set; }
        public IEnumerable<IOrderSearchSorting> SortEnumerable { set => Sort = value.ToList(); }


        public int? Limit { get; set; }

        public int? Offset { get; set; }
    }
}
