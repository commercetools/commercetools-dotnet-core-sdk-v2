using commercetools.HistoryApi.Models.Common;


namespace commercetools.HistoryApi.Models.Changes
{
    public partial class SetProductPriceCustomFieldChange : ISetProductPriceCustomFieldChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public string CatalogData { get; set; }

        public ICustomFields PreviousValue { get; set; }

        public ICustomFields NextValue { get; set; }
        public SetProductPriceCustomFieldChange()
        {
            this.Type = "SetProductPriceCustomFieldChange";
        }
    }
}
