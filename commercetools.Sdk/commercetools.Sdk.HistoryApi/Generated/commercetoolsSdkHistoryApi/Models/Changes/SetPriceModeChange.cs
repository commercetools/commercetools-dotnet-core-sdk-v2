using commercetools.Sdk.HistoryApi.Models.Common;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{

    public partial class SetPriceModeChange : ISetPriceModeChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public IProductPriceModeEnum PreviousValue { get; set; }

        public IProductPriceModeEnum NextValue { get; set; }
        public SetPriceModeChange()
        {
            this.Type = "SetPriceModeChange";
        }
    }
}
