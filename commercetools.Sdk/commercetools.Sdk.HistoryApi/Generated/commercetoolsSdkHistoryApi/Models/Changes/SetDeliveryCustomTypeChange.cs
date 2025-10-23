using commercetools.Sdk.HistoryApi.Models.Common;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{

    public partial class SetDeliveryCustomTypeChange : ISetDeliveryCustomTypeChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public string DeliveryId { get; set; }

        public ICustomFields PreviousValue { get; set; }

        public ICustomFields NextValue { get; set; }
        public SetDeliveryCustomTypeChange()
        {
            this.Type = "SetDeliveryCustomTypeChange";
        }
    }
}
