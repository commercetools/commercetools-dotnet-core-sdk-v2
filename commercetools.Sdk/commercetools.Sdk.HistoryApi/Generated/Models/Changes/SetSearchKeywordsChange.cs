using commercetools.Sdk.HistoryApi.Models.Common;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{

    public partial class SetSearchKeywordsChange : ISetSearchKeywordsChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public string CatalogData { get; set; }

        public ISearchKeywords PreviousValue { get; set; }

        public ISearchKeywords NextValue { get; set; }
        public SetSearchKeywordsChange()
        {
            this.Type = "SetSearchKeywordsChange";
        }
    }
}
