using System;


namespace commercetools.HistoryApi.Models.Changes
{
    public partial class SetPropertyChange : ISetPropertyChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public string Path { get; set; }

        public Object NextValue { get; set; }

        public Object PreviousValue { get; set; }
        public SetPropertyChange()
        {
            this.Type = "SetPropertyChange";
        }
    }
}
