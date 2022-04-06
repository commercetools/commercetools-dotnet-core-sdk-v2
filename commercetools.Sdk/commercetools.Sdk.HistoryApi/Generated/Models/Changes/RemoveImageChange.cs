using commercetools.Sdk.HistoryApi.Models.Common;
using System.Collections.Generic;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    public partial class RemoveImageChange : IRemoveImageChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public string CatalogData { get; set; }

        public List<IImage> PreviousValue { get; set; }

        public List<IImage> NextValue { get; set; }
        public RemoveImageChange()
        {
            this.Type = "RemoveImageChange";
        }
    }
}
