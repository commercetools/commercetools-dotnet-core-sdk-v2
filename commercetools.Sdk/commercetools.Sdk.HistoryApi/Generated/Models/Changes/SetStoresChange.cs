using commercetools.Sdk.HistoryApi.Models.Common;
using System.Collections.Generic;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{

    public partial class SetStoresChange : ISetStoresChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public List<IReference> PreviousValue { get; set; }

        public List<IReference> NextValue { get; set; }
        public SetStoresChange()
        {
            this.Type = "SetStoresChange";
        }
    }
}
