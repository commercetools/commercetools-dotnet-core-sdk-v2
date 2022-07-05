using commercetools.Sdk.HistoryApi.Models.Common;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{

    public partial class SetProductPriceCustomTypeChange : ISetProductPriceCustomTypeChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public string CatalogData { get; set; }

        public ICustomFields PreviousValue { get; set; }

        public ICustomFields NextValue { get; set; }
        public SetProductPriceCustomTypeChange()
        {
            this.Type = "SetProductPriceCustomTypeChange";
        }
    }
}
