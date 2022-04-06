using System;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    public partial class AddPropertyChange : IAddPropertyChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public string Path { get; set; }

        public Object NextValue { get; set; }
        public AddPropertyChange()
        {
            this.Type = "AddPropertyChange";
        }
    }
}
