namespace commercetools.Sdk.HistoryApi.Models.Changes
{

    public partial class ChangeModel : IChange
    {
        public string Type { get; set; }

        public string Change { get; set; }
    }
}
