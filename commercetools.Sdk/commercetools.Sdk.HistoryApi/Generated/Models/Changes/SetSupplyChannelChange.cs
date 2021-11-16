using commercetools.HistoryApi.Models.Common;


namespace commercetools.HistoryApi.Models.Changes
{
    public partial class SetSupplyChannelChange : ISetSupplyChannelChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public IReference PreviousValue { get; set; }

        public IReference NextValue { get; set; }
        public SetSupplyChannelChange()
        {
            this.Type = "SetSupplyChannelChange";
        }
    }
}
