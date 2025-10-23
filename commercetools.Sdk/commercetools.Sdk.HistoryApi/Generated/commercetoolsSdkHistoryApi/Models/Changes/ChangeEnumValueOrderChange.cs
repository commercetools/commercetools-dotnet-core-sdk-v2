using commercetools.Sdk.HistoryApi.Models.Common;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.HistoryApi.Models.Changes
{

    public partial class ChangeEnumValueOrderChange : IChangeEnumValueOrderChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public IList<ICustomFieldEnumValue> PreviousValue { get; set; }

        public IEnumerable<ICustomFieldEnumValue> PreviousValueEnumerable { set => PreviousValue = value.ToList(); }

        public IList<ICustomFieldEnumValue> NextValue { get; set; }

        public IEnumerable<ICustomFieldEnumValue> NextValueEnumerable { set => NextValue = value.ToList(); }

        public string FieldName { get; set; }

        public string AttributeName { get; set; }
        public ChangeEnumValueOrderChange()
        {
            this.Type = "ChangeEnumValueOrderChange";
        }
    }
}
