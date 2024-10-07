using commercetools.Sdk.HistoryApi.Models.ChangeValues;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.HistoryApi.Models.Changes
{

    public partial class ChangeLocalizedEnumValueOrderChange : IChangeLocalizedEnumValueOrderChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public IList<ILocalizedEnumValue> PreviousValue { get; set; }

        public IEnumerable<ILocalizedEnumValue> PreviousValueEnumerable { set => PreviousValue = value.ToList(); }

        public IList<ILocalizedEnumValue> NextValue { get; set; }

        public IEnumerable<ILocalizedEnumValue> NextValueEnumerable { set => NextValue = value.ToList(); }

        public string FieldName { get; set; }

        public string AttributeName { get; set; }
        public ChangeLocalizedEnumValueOrderChange()
        {
            this.Type = "ChangeLocalizedEnumValueOrderChange";
        }
    }
}
