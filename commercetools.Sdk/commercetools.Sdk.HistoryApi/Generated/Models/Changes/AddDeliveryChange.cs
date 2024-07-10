using commercetools.Sdk.HistoryApi.Models.ChangeValues;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{

    public partial class AddDeliveryChange : IAddDeliveryChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public IDeliveryChangeValue PreviousValue { get; set; }

        public IDeliveryChangeValue NextValue { get; set; }
        public AddDeliveryChange()
        {
            this.Type = "AddDeliveryChange";
        }
    }
}
