using commercetools.Sdk.HistoryApi.Models.ChangeValues;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.HistoryApi.Models.Changes
{

    public partial class SetAssetTagsChange : ISetAssetTagsChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public IList<string> PreviousValue { get; set; }

        public IEnumerable<string> PreviousValueEnumerable { set => PreviousValue = value.ToList(); }

        public IList<string> NextValue { get; set; }

        public IEnumerable<string> NextValueEnumerable { set => NextValue = value.ToList(); }

        public IAssetChangeValue Asset { get; set; }
        public SetAssetTagsChange()
        {
            this.Type = "SetAssetTagsChange";
        }
    }
}
