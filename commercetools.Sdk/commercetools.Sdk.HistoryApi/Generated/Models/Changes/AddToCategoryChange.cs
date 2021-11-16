using commercetools.HistoryApi.Models.Common;
using System.Collections.Generic;


namespace commercetools.HistoryApi.Models.Changes
{
    public partial class AddToCategoryChange : IAddToCategoryChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public IReference Category { get; set; }

        public List<IReference> PreviousValue { get; set; }

        public List<IReference> NextValue { get; set; }
        public AddToCategoryChange()
        {
            this.Type = "AddToCategoryChange";
        }
    }
}
