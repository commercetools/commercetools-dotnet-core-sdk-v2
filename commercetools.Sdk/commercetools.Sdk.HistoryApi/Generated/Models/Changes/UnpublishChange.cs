namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    public partial class UnpublishChange : IUnpublishChange
    {
        public string Type { get; set; }

        public string Change { get; set; }
        public UnpublishChange()
        {
            this.Type = "UnpublishChange";
        }
    }
}
