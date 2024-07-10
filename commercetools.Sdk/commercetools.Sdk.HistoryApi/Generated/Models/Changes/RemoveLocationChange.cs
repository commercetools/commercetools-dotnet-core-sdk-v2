using commercetools.Sdk.HistoryApi.Models.Common;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{

    public partial class RemoveLocationChange : IRemoveLocationChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public ILocation PreviousValue { get; set; }
        public RemoveLocationChange()
        {
            this.Type = "RemoveLocationChange";
        }
    }
}
