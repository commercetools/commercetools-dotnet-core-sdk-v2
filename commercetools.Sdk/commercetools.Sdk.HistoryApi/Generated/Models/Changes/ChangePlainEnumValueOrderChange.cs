using commercetools.Sdk.HistoryApi.Models.ChangeValues;
using System.Collections.Generic;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{

    public partial class ChangePlainEnumValueOrderChange : IChangePlainEnumValueOrderChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public string AttributeName { get; set; }

        public List<IEnumValue> NextValue { get; set; }

        public List<IEnumValue> PreviousValue { get; set; }
        public ChangePlainEnumValueOrderChange()
        {
            this.Type = "ChangePlainEnumValueOrderChange";
        }
    }
}
