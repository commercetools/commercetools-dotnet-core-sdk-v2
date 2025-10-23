using commercetools.Sdk.HistoryApi.Models.Common;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{

    public partial class SetAttributeChange : ISetAttributeChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public IAttribute PreviousValue { get; set; }

        public IAttribute NextValue { get; set; }

        public string CatalogData { get; set; }

        public string Variant { get; set; }
        public SetAttributeChange()
        {
            this.Type = "SetAttributeChange";
        }
    }
}
