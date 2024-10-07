using commercetools.Sdk.HistoryApi.Models.ChangeValues;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.HistoryApi.Models.Changes
{

    public partial class ChangeFieldDefinitionOrderChange : IChangeFieldDefinitionOrderChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public IList<IFieldDefinitionOrderValue> PreviousValue { get; set; }

        public IEnumerable<IFieldDefinitionOrderValue> PreviousValueEnumerable { set => PreviousValue = value.ToList(); }

        public IList<IFieldDefinitionOrderValue> NextValue { get; set; }

        public IEnumerable<IFieldDefinitionOrderValue> NextValueEnumerable { set => NextValue = value.ToList(); }
        public ChangeFieldDefinitionOrderChange()
        {
            this.Type = "ChangeFieldDefinitionOrderChange";
        }
    }
}
