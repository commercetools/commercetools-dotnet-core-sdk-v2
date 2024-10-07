using System;

namespace commercetools.Sdk.Api.Models.Orders
{

    public partial class OrderSearchDateRangeValue : IOrderSearchDateRangeValue
    {
        public string Field { get; set; }

        public int? Boost { get; set; }

        public IOrderSearchCustomType CustomType { get; set; }

        public DateTime? Gte { get; set; }

        public DateTime? Lte { get; set; }
    }
}
