using commercetools.Sdk.HistoryApi.Models.Changes;
using commercetools.Sdk.HistoryApi.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{

    public partial class SetTransitionsChange : ISetTransitionsChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public IList<IReference> PreviousValue { get; set; }
        public IEnumerable<IReference> PreviousValueEnumerable { set => PreviousValue = value.ToList(); }


        public IList<IReference> NextValue { get; set; }
        public IEnumerable<IReference> NextValueEnumerable { set => NextValue = value.ToList(); }

        public SetTransitionsChange()
        {
            this.Type = "SetTransitionsChange";
        }
    }
}
