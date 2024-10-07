using commercetools.Sdk.HistoryApi.Models.Common;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.HistoryApi.Models.Changes
{

    public partial class SetPermissionsChange : ISetPermissionsChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public IList<IPermission> PreviousValue { get; set; }

        public IEnumerable<IPermission> PreviousValueEnumerable { set => PreviousValue = value.ToList(); }

        public IList<IPermission> NextValue { get; set; }

        public IEnumerable<IPermission> NextValueEnumerable { set => NextValue = value.ToList(); }
        public SetPermissionsChange()
        {
            this.Type = "SetPermissionsChange";
        }
    }
}
