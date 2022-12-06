using commercetools.Sdk.HistoryApi.Models.ChangeValues;
using System.Collections.Generic;
using System.Linq;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{

    public partial class ChangePlainEnumValueOrderChange : IChangePlainEnumValueOrderChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public string AttributeName { get; set; }

        public IList<IEnumValue> NextValue { get; set; }
        public IEnumerable<IEnumValue> NextValueEnumerable { set => NextValue = value.ToList(); }


        public IList<IEnumValue> PreviousValue { get; set; }
        public IEnumerable<IEnumValue> PreviousValueEnumerable { set => PreviousValue = value.ToList(); }

        public ChangePlainEnumValueOrderChange()
        {
            this.Type = "ChangePlainEnumValueOrderChange";
        }
    }
}
