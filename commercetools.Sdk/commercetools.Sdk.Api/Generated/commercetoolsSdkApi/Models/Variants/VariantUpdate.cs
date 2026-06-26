using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.Api.Models.Variants
{

    public partial class VariantUpdate : IVariantUpdate
    {
        public long Version { get; set; }

        public IList<IVariantUpdateAction> Actions { get; set; }

        public IEnumerable<IVariantUpdateAction> ActionsEnumerable { set => Actions = value.ToList(); }
    }
}
