using commercetools.HistoryApi.Models.Changes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.Changes
{
    public partial class ChangeEnumValueLabelChange : IChangeEnumValueLabelChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public string FieldName { get; set; }

        public string ValueKey { get; set; }

        public string PreviousValue { get; set; }

        public string NextValue { get; set; }
        public ChangeEnumValueLabelChange()
        {
            this.Type = "ChangeEnumValueLabelChange";
        }
    }
}
