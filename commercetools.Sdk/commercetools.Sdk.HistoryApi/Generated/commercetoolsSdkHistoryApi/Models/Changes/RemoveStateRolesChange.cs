using commercetools.Sdk.HistoryApi.Models.Common;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.HistoryApi.Models.Changes
{

    public partial class RemoveStateRolesChange : IRemoveStateRolesChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public IList<IStateRoleEnum> PreviousValue { get; set; }

        public IEnumerable<IStateRoleEnum> PreviousValueEnumerable { set => PreviousValue = value.ToList(); }

        public IList<IStateRoleEnum> NextValue { get; set; }

        public IEnumerable<IStateRoleEnum> NextValueEnumerable { set => NextValue = value.ToList(); }
        public RemoveStateRolesChange()
        {
            this.Type = "RemoveStateRolesChange";
        }
    }
}
