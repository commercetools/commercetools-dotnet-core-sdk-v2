using commercetools.Sdk.HistoryApi.Models.ChangeValues;
using commercetools.Sdk.HistoryApi.Models.Common;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.HistoryApi.Models.Changes
{

    public partial class SetAssetSourcesChange : ISetAssetSourcesChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public IList<IAssetSource> PreviousValue { get; set; }

        public IEnumerable<IAssetSource> PreviousValueEnumerable { set => PreviousValue = value.ToList(); }

        public IList<IAssetSource> NextValue { get; set; }

        public IEnumerable<IAssetSource> NextValueEnumerable { set => NextValue = value.ToList(); }

        public IAssetChangeValue Asset { get; set; }
        public SetAssetSourcesChange()
        {
            this.Type = "SetAssetSourcesChange";
        }
    }
}
