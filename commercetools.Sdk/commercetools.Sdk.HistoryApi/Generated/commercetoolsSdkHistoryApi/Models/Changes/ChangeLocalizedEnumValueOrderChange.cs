using commercetools.Sdk.HistoryApi.Models.Common;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.HistoryApi.Models.Changes
{

    public partial class ChangeLocalizedEnumValueOrderChange : IChangeLocalizedEnumValueOrderChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public IList<IAttributeLocalizedEnumValue> PreviousValue { get; set; }

        public IEnumerable<IAttributeLocalizedEnumValue> PreviousValueEnumerable { set => PreviousValue = value.ToList(); }

        public IList<IAttributeLocalizedEnumValue> NextValue { get; set; }

        public IEnumerable<IAttributeLocalizedEnumValue> NextValueEnumerable { set => NextValue = value.ToList(); }

        public string FieldName { get; set; }

        public string AttributeName { get; set; }
        public ChangeLocalizedEnumValueOrderChange()
        {
            this.Type = "ChangeLocalizedEnumValueOrderChange";
        }
    }
}
