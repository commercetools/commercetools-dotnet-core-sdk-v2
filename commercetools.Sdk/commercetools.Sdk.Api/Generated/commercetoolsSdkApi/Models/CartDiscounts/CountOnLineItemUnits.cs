

namespace commercetools.Sdk.Api.Models.CartDiscounts
{

    public partial class CountOnLineItemUnits : ICountOnLineItemUnits
    {
        public string Type { get; set; }

        public string Predicate { get; set; }

        public int? MinCount { get; set; }

        public int? MaxCount { get; set; }

        public int? ExcludeCount { get; set; }
        public CountOnLineItemUnits()
        {
            this.Type = "CountOnLineItemUnits";
        }
    }
}
