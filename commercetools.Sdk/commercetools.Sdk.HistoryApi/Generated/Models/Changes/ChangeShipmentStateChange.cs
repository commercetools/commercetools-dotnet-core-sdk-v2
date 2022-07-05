using commercetools.Sdk.HistoryApi.Models.Common;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{

    public partial class ChangeShipmentStateChange : IChangeShipmentStateChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public IShipmentState NextValue { get; set; }

        public IShipmentState PreviousValue { get; set; }
        public ChangeShipmentStateChange()
        {
            this.Type = "ChangeShipmentStateChange";
        }
    }
}
