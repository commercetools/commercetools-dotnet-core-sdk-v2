using commercetools.Sdk.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Orders
{

    public partial class OrderSearchSorting : IOrderSearchSorting
    {
        public string Field { get; set; }

        public string Language { get; set; }

        public IOrderSearchSortOrder Order { get; set; }

        public IOrderSearchSortMode Mode { get; set; }

        public IOrderSearchQueryExpression Filter { get; set; }
    }
}
