using commercetools.Sdk.HistoryApi.Models.Common;
using System.Collections.Generic;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    public partial class RemoveFromCategoryChange : IRemoveFromCategoryChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public IReference Category { get; set; }

        public List<IReference> PreviousValue { get; set; }

        public List<IReference> NextValue { get; set; }
        public RemoveFromCategoryChange()
        {
            this.Type = "RemoveFromCategoryChange";
        }
    }
}
