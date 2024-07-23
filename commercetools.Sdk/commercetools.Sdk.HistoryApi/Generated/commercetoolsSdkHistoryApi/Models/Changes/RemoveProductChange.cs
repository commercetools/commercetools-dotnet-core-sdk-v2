using commercetools.Sdk.HistoryApi.Models.Common;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{

    public partial class RemoveProductChange : IRemoveProductChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public IReference PreviousValue { get; set; }
        public RemoveProductChange()
        {
            this.Type = "RemoveProductChange";
        }
    }
}
