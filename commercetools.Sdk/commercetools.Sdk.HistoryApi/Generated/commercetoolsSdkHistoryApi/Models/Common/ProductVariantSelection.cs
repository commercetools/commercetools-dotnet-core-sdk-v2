using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.HistoryApi.Models.Common
{

    public partial class ProductVariantSelection : IProductVariantSelection
    {
        public IProductVariantSelectionTypeEnum Type { get; set; }

        public IList<string> Skus { get; set; }

        public IEnumerable<string> SkusEnumerable { set => Skus = value.ToList(); }
    }
}
