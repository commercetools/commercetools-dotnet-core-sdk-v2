using System;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{

    public partial class SetShippingRateInputChange : ISetShippingRateInputChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public Object PreviousValue { get; set; }

        public Object NextValue { get; set; }
        public SetShippingRateInputChange()
        {
            this.Type = "SetShippingRateInputChange";
        }
    }
}
