using commercetools.Sdk.HistoryApi.Models.Common;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{

    public partial class SetMetaDescriptionChange : ISetMetaDescriptionChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public ILocalizedString PreviousValue { get; set; }

        public ILocalizedString NextValue { get; set; }

        public string CatalogData { get; set; }
        public SetMetaDescriptionChange()
        {
            this.Type = "SetMetaDescriptionChange";
        }
    }
}
