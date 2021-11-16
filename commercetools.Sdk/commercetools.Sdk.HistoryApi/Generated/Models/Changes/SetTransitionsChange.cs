using commercetools.HistoryApi.Models.Common;
using System.Collections.Generic;


namespace commercetools.HistoryApi.Models.Changes
{
    public partial class SetTransitionsChange : ISetTransitionsChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public List<IReference> PreviousValue { get; set; }

        public List<IReference> NextValue { get; set; }
        public SetTransitionsChange()
        {
            this.Type = "SetTransitionsChange";
        }
    }
}
