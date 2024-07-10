using commercetools.Sdk.HistoryApi.Models.Common;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{

    public partial class RemoveVariantChange : IRemoveVariantChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public IVariant PreviousValue { get; set; }

        public IVariant NextValue { get; set; }

        public string CatalogData { get; set; }
        public RemoveVariantChange()
        {
            this.Type = "RemoveVariantChange";
        }
    }
}
