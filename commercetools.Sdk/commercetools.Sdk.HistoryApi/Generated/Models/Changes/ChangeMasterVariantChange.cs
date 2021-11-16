using commercetools.HistoryApi.Models.Common;


namespace commercetools.HistoryApi.Models.Changes
{
    public partial class ChangeMasterVariantChange : IChangeMasterVariantChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public string CatalogData { get; set; }

        public IVariant PreviousValue { get; set; }

        public IVariant NextValue { get; set; }
        public ChangeMasterVariantChange()
        {
            this.Type = "ChangeMasterVariantChange";
        }
    }
}
