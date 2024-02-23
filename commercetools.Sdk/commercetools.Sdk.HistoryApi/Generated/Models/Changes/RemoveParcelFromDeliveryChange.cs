using commercetools.Sdk.HistoryApi.Models.Common;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{

    public partial class RemoveParcelFromDeliveryChange : IRemoveParcelFromDeliveryChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public IParcel PreviousValue { get; set; }

        public string DeliveryId { get; set; }
        public RemoveParcelFromDeliveryChange()
        {
            this.Type = "RemoveParcelFromDeliveryChange";
        }
    }
}
