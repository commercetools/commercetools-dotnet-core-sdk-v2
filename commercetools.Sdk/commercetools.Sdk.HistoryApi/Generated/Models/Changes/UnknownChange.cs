using System;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{

    public partial class UnknownChange : IUnknownChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public Object PreviousValue { get; set; }

        public Object NextValue { get; set; }
        public UnknownChange()
        {
            this.Type = "UnknownChange";
        }
    }
}
