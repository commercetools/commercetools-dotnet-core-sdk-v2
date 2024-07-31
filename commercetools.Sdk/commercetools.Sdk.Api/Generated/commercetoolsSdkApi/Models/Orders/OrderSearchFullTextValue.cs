

namespace commercetools.Sdk.Api.Models.Orders
{

    public partial class OrderSearchFullTextValue : IOrderSearchFullTextValue
    {
        public string Field { get; set; }

        public int? Boost { get; set; }

        public IOrderSearchCustomType CustomType { get; set; }

        public string Value { get; set; }

        public string Language { get; set; }

        public IOrderSearchMatchType MustMatch { get; set; }
    }
}
