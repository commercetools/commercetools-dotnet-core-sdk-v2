namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    public partial class PublishChange : IPublishChange
    {
        public string Type { get; set; }

        public string Change { get; set; }
        public PublishChange()
        {
            this.Type = "PublishChange";
        }
    }
}
