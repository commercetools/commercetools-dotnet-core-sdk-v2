using System;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{

    public partial class SetCustomFieldChange : ISetCustomFieldChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public string Name { get; set; }

        public string CustomTypeId { get; set; }

        public Object NextValue { get; set; }

        public Object PreviousValue { get; set; }
        public SetCustomFieldChange()
        {
            this.Type = "SetCustomFieldChange";
        }
    }
}
