using commercetools.Sdk.HistoryApi.Models.Common;
using System.Collections.Generic;
using System.Linq;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{

    public partial class SetStateRolesChange : ISetStateRolesChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public IList<IStateRole> PreviousValue { get; set; }
        public IEnumerable<IStateRole> PreviousValueEnumerable { set => PreviousValue = value.ToList(); }


        public IList<IStateRole> NextValue { get; set; }
        public IEnumerable<IStateRole> NextValueEnumerable { set => NextValue = value.ToList(); }

        public SetStateRolesChange()
        {
            this.Type = "SetStateRolesChange";
        }
    }
}
