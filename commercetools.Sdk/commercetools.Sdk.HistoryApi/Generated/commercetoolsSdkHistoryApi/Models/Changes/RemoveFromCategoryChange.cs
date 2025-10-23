using commercetools.Sdk.HistoryApi.Models.Common;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.HistoryApi.Models.Changes
{

    public partial class RemoveFromCategoryChange : IRemoveFromCategoryChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public IList<IReference> PreviousValue { get; set; }

        public IEnumerable<IReference> PreviousValueEnumerable { set => PreviousValue = value.ToList(); }

        public IList<IReference> NextValue { get; set; }

        public IEnumerable<IReference> NextValueEnumerable { set => NextValue = value.ToList(); }

        public IReference Category { get; set; }

        public string CatalogData { get; set; }
        public RemoveFromCategoryChange()
        {
            this.Type = "RemoveFromCategoryChange";
        }
    }
}
