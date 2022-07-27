using commercetools.Sdk.HistoryApi.Models.ChangeValues;
using System.Collections.Generic;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{

    public partial class ChangeLocalizedEnumValueOrderChange : IChangeLocalizedEnumValueOrderChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public string FieldName { get; set; }

        public string AttributeName { get; set; }

        public List<ILocalizedEnumValue> NextValue { get; set; }

        public List<ILocalizedEnumValue> PreviousValue { get; set; }
        public ChangeLocalizedEnumValueOrderChange()
        {
            this.Type = "ChangeLocalizedEnumValueOrderChange";
        }
    }
}
