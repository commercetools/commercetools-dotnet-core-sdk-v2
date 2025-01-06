

namespace commercetools.Sdk.Api.Models.CartDiscounts
{

    public partial class CountOnCustomLineItemUnits : ICountOnCustomLineItemUnits
    {
        public string Type { get; set; }

        public string Predicate { get; set; }

        public int? MinCount { get; set; }

        public int? MaxCount { get; set; }

        public int? ExcludeCount { get; set; }
        public CountOnCustomLineItemUnits()
        {
            this.Type = "CountOnCustomLineItemUnits";
        }
    }
}
