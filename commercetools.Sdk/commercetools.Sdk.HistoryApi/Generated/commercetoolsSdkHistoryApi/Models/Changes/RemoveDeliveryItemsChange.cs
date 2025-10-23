using commercetools.Sdk.HistoryApi.Models.ChangeValues;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{

    public partial class RemoveDeliveryItemsChange : IRemoveDeliveryItemsChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public IDeliveryChangeValue PreviousValue { get; set; }
        public RemoveDeliveryItemsChange()
        {
            this.Type = "RemoveDeliveryItemsChange";
        }
    }
}
