using commercetools.Sdk.HistoryApi.Models.Common;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.HistoryApi.Models.Changes
{

    public partial class AddExternalImageChange : IAddExternalImageChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public IList<IImage> PreviousValue { get; set; }

        public IEnumerable<IImage> PreviousValueEnumerable { set => PreviousValue = value.ToList(); }

        public IList<IImage> NextValue { get; set; }

        public IEnumerable<IImage> NextValueEnumerable { set => NextValue = value.ToList(); }

        public string CatalogData { get; set; }

        public string Variant { get; set; }
        public AddExternalImageChange()
        {
            this.Type = "AddExternalImageChange";
        }
    }
}
