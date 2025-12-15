

namespace commercetools.Sdk.HistoryApi.Models.Changes
{

    public partial class ShippingMethodSetPredicateChange : IShippingMethodSetPredicateChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public string PreviousValue { get; set; }

        public string NextValue { get; set; }
        public ShippingMethodSetPredicateChange()
        {
            this.Type = "ShippingMethodSetPredicateChange";
        }
    }
}
