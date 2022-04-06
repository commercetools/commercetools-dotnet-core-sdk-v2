using System.Collections.Generic;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    public partial class ChangeGroupsChange : IChangeGroupsChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public List<string> PreviousValue { get; set; }

        public List<string> NextValue { get; set; }
        public ChangeGroupsChange()
        {
            this.Type = "ChangeGroupsChange";
        }
    }
}
