using System;


namespace commercetools.Sdk.Api.Models.Orders
{

    public partial class OrderSearchAnyValue : IOrderSearchAnyValue
    {
        public string Field { get; set; }

        public int? Boost { get; set; }

        public IOrderSearchCustomType CustomType { get; set; }

        public Object Value { get; set; }

        public string Language { get; set; }

        public bool? CaseInsensitive { get; set; }
    }
}
