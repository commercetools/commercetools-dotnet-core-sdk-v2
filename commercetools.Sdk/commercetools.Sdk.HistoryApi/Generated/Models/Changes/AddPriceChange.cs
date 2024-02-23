using commercetools.Sdk.HistoryApi.Models.Common;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{

    public partial class AddPriceChange : IAddPriceChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public IPrice NextValue { get; set; }

        public string CatalogData { get; set; }

        public string PriceId { get; set; }
        public AddPriceChange()
        {
            this.Type = "AddPriceChange";
        }
    }
}
