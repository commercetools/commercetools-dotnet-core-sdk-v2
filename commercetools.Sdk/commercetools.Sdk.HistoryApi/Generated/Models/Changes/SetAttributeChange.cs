using commercetools.Sdk.HistoryApi.Models.ChangeValues;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{

    public partial class SetAttributeChange : ISetAttributeChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public IAttributeValue PreviousValue { get; set; }

        public IAttributeValue NextValue { get; set; }

        public string CatalogData { get; set; }
        public SetAttributeChange()
        {
            this.Type = "SetAttributeChange";
        }
    }
}
