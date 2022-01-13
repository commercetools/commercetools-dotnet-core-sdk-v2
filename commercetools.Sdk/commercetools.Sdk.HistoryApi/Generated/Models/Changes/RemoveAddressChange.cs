using commercetools.HistoryApi.Models.Common;


namespace commercetools.HistoryApi.Models.Changes
{
    public partial class RemoveAddressChange : IRemoveAddressChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public IAddress PreviousValue { get; set; }
        public RemoveAddressChange()
        {
            this.Type = "RemoveAddressChange";
        }
    }
}
