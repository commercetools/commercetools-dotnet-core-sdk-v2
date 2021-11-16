using commercetools.HistoryApi.Models.Common;
using System.Collections.Generic;


namespace commercetools.HistoryApi.Models.Changes
{
    public partial class RemoveStateRolesChange : IRemoveStateRolesChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public List<IStateRole> PreviousValue { get; set; }

        public List<IStateRole> NextValue { get; set; }
        public RemoveStateRolesChange()
        {
            this.Type = "RemoveStateRolesChange";
        }
    }
}
