using commercetools.HistoryApi.Models.Changes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.Changes
{
    public partial class SetLanguagesChange : ISetLanguagesChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public List<string> PreviousValue { get; set; }

        public List<string> NextValue { get; set; }
        public SetLanguagesChange()
        {
            this.Type = "SetLanguagesChange";
        }
    }
}
