using commercetools.Sdk.HistoryApi.Models.Common;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{

    public partial class SetInputTipChange : ISetInputTipChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public string AttributeName { get; set; }

        public ILocalizedString NextValue { get; set; }

        public ILocalizedString PreviousValue { get; set; }
        public SetInputTipChange()
        {
            this.Type = "SetInputTipChange";
        }
    }
}
