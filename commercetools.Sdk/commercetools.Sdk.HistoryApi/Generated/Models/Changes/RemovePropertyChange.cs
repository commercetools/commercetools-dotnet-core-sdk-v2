using System;


namespace commercetools.HistoryApi.Models.Changes
{
    public partial class RemovePropertyChange : IRemovePropertyChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public string Path { get; set; }

        public Object PreviousValue { get; set; }
        public RemovePropertyChange()
        {
            this.Type = "RemovePropertyChange";
        }
    }
}
