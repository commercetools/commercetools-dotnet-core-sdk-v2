using commercetools.Sdk.HistoryApi.Models.Common;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    public partial class SetCategoryOrderHintChange : ISetCategoryOrderHintChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public string CatalogData { get; set; }

        public string CategoryId { get; set; }

        public ICategoryOrderHints PreviousValue { get; set; }

        public ICategoryOrderHints NextValue { get; set; }
        public SetCategoryOrderHintChange()
        {
            this.Type = "SetCategoryOrderHintChange";
        }
    }
}
