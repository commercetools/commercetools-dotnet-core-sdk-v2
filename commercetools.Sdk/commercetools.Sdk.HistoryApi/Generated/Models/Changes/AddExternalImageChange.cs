using commercetools.Sdk.HistoryApi.Models.Common;
using System.Collections.Generic;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{

    public partial class AddExternalImageChange : IAddExternalImageChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public string CatalogData { get; set; }

        public List<IImage> PreviousValue { get; set; }

        public List<IImage> NextValue { get; set; }
        public AddExternalImageChange()
        {
            this.Type = "AddExternalImageChange";
        }
    }
}
