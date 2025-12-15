

namespace commercetools.Sdk.HistoryApi.Models.Labels
{

    public partial class StandalonePriceLabel : IStandalonePriceLabel
    {
        public string Type { get; set; }

        public string Key { get; set; }

        public string Sku { get; set; }
        public StandalonePriceLabel()
        {
            this.Type = "StandalonePriceLabel";
        }
    }
}
