

namespace commercetools.Sdk.HistoryApi.Models.Changes
{

    public partial class SetProductVariantKeyChange : ISetProductVariantKeyChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public string PreviousValue { get; set; }

        public string NextValue { get; set; }

        public string CatalogData { get; set; }
        public SetProductVariantKeyChange()
        {
            this.Type = "SetProductVariantKeyChange";
        }
    }
}
