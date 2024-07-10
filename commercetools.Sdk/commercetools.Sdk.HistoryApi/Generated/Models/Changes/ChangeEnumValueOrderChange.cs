using commercetools.Sdk.HistoryApi.Models.ChangeValues;
using commercetools.Sdk.HistoryApi.Models.Changes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{

    public partial class ChangeEnumValueOrderChange : IChangeEnumValueOrderChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public IList<IEnumValue> PreviousValue { get; set; }
        public IEnumerable<IEnumValue> PreviousValueEnumerable { set => PreviousValue = value.ToList(); }


        public IList<IEnumValue> NextValue { get; set; }
        public IEnumerable<IEnumValue> NextValueEnumerable { set => NextValue = value.ToList(); }


        public string FieldName { get; set; }
        public ChangeEnumValueOrderChange()
        {
            this.Type = "ChangeEnumValueOrderChange";
        }
    }
}
