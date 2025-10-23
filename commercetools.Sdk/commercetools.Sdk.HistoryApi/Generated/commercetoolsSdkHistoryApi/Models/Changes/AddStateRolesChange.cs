using commercetools.Sdk.HistoryApi.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [Obsolete("usage of this endpoint has been deprecated.", false)]
    public partial class AddStateRolesChange : IAddStateRolesChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public IList<IStateRoleEnum> PreviousValue { get; set; }

        public IEnumerable<IStateRoleEnum> PreviousValueEnumerable { set => PreviousValue = value.ToList(); }

        public IList<IStateRoleEnum> NextValue { get; set; }

        public IEnumerable<IStateRoleEnum> NextValueEnumerable { set => NextValue = value.ToList(); }
        public AddStateRolesChange()
        {
            this.Type = "AddStateRolesChange";
        }
    }
}
