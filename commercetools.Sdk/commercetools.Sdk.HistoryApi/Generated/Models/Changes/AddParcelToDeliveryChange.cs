using commercetools.HistoryApi.Models.Common;


namespace commercetools.HistoryApi.Models.Changes
{
    public partial class AddParcelToDeliveryChange : IAddParcelToDeliveryChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public string DeliveryId { get; set; }

        public IParcel NextValue { get; set; }
        public AddParcelToDeliveryChange()
        {
            this.Type = "AddParcelToDeliveryChange";
        }
    }
}
