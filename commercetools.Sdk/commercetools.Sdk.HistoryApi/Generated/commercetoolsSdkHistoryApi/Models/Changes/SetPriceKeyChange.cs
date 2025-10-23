

namespace commercetools.Sdk.HistoryApi.Models.Changes
{

    public partial class SetPriceKeyChange : ISetPriceKeyChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public string CatalogData { get; set; }

        public string Variant { get; set; }

        public string PriceId { get; set; }

        public string PreviousValue { get; set; }

        public string NextValue { get; set; }
        public SetPriceKeyChange()
        {
            this.Type = "SetPriceKeyChange";
        }
    }
}
