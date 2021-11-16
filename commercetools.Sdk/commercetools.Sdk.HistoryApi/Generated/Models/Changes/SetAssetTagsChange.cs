using commercetools.HistoryApi.Models.ChangeValues;
using System.Collections.Generic;


namespace commercetools.HistoryApi.Models.Changes
{
    public partial class SetAssetTagsChange : ISetAssetTagsChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public IAssetChangeValue Asset { get; set; }

        public List<string> NextValue { get; set; }

        public List<string> PreviousValue { get; set; }
        public SetAssetTagsChange()
        {
            this.Type = "SetAssetTagsChange";
        }
    }
}
