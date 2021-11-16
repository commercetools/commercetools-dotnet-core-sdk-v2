using commercetools.HistoryApi.Models.ChangeValues;
using commercetools.HistoryApi.Models.Common;


namespace commercetools.HistoryApi.Models.Changes
{
    public partial class SetAssetCustomTypeChange : ISetAssetCustomTypeChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public IAssetChangeValue Asset { get; set; }

        public ICustomFields NextValue { get; set; }

        public ICustomFields PreviousValue { get; set; }
        public SetAssetCustomTypeChange()
        {
            this.Type = "SetAssetCustomTypeChange";
        }
    }
}
