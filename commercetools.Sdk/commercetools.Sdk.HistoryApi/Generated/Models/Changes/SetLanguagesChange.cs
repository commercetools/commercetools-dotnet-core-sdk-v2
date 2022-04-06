using System.Collections.Generic;


namespace commercetools.Sdk.HistoryApi.Models.Changes
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
