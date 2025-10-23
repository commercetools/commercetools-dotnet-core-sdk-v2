using commercetools.Sdk.HistoryApi.Models.Common;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.HistoryApi.Models.Changes
{

    public partial class ChangePlainEnumValueOrderChange : IChangePlainEnumValueOrderChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public IList<IAttributePlainEnumValue> PreviousValue { get; set; }

        public IEnumerable<IAttributePlainEnumValue> PreviousValueEnumerable { set => PreviousValue = value.ToList(); }

        public IList<IAttributePlainEnumValue> NextValue { get; set; }

        public IEnumerable<IAttributePlainEnumValue> NextValueEnumerable { set => NextValue = value.ToList(); }

        public string AttributeName { get; set; }
        public ChangePlainEnumValueOrderChange()
        {
            this.Type = "ChangePlainEnumValueOrderChange";
        }
    }
}
