using commercetools.Sdk.HistoryApi.Models.Common;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{

    public partial class SetProductAttributeChange : ISetProductAttributeChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public string CatalogData { get; set; }

        public IAttribute PreviousValue { get; set; }

        public IAttribute NextValue { get; set; }
        public SetProductAttributeChange()
        {
            this.Type = "SetProductAttributeChange";
        }
    }
}
