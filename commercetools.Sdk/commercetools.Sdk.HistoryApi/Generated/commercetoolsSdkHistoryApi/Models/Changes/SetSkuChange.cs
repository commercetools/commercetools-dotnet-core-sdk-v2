namespace commercetools.Sdk.HistoryApi.Models.Changes
{

    public partial class SetSkuChange : ISetSkuChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public string PreviousValue { get; set; }

        public string NextValue { get; set; }

        public string CatalogData { get; set; }
        public SetSkuChange()
        {
            this.Type = "SetSkuChange";
        }
    }
}
