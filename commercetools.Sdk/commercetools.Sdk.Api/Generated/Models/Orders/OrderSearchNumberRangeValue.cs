using commercetools.Sdk.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Orders
{

    public partial class OrderSearchNumberRangeValue : IOrderSearchNumberRangeValue
    {
        public string Field { get; set; }

        public int? Boost { get; set; }

        public string CustomType { get; set; }

        public decimal? Gte { get; set; }

        public decimal? Lte { get; set; }
    }
}
