using commercetools.Sdk.HistoryApi.Models.Common;
using System.Collections.Generic;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{

    public partial class SetDistributionChannelsChange : ISetDistributionChannelsChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public List<IReference> PreviousValue { get; set; }

        public List<IReference> NextValue { get; set; }
        public SetDistributionChannelsChange()
        {
            this.Type = "SetDistributionChannelsChange";
        }
    }
}
