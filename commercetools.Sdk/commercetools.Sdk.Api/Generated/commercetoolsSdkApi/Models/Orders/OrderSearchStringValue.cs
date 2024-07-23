namespace commercetools.Sdk.Api.Models.Orders
{

    public partial class OrderSearchStringValue : IOrderSearchStringValue
    {
        public string Field { get; set; }

        public int? Boost { get; set; }

        public IOrderSearchCustomType CustomType { get; set; }

        public string Value { get; set; }

        public string Language { get; set; }

        public bool? CaseInsensitive { get; set; }
    }
}
