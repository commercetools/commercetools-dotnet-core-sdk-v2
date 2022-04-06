using commercetools.Sdk.HistoryApi.Models.ChangeValues;
using System.Collections.Generic;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    public partial class ChangeEnumValueOrderChange : IChangeEnumValueOrderChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public string FieldName { get; set; }

        public List<IEnumValue> NextValue { get; set; }

        public List<IEnumValue> PreviousValue { get; set; }
        public ChangeEnumValueOrderChange()
        {
            this.Type = "ChangeEnumValueOrderChange";
        }
    }
}
