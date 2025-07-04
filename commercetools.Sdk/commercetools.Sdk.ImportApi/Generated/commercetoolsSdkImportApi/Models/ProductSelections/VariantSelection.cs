using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.ImportApi.Models.ProductSelections
{

    public partial class VariantSelection : IVariantSelection
    {
        public IVariantSelectionType Type { get; set; }

        public IList<string> Skus { get; set; }

        public IEnumerable<string> SkusEnumerable { set => Skus = value.ToList(); }
    }
}
