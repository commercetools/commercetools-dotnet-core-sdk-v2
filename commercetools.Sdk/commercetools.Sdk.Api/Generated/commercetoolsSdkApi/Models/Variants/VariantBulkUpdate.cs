using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.Api.Models.Variants
{

    public partial class VariantBulkUpdate : IVariantBulkUpdate
    {
        public IList<IVariantBulkUpdateItem> Items { get; set; }

        public IEnumerable<IVariantBulkUpdateItem> ItemsEnumerable { set => Items = value.ToList(); }

        public IList<IVariantUpdateAction> Actions { get; set; }

        public IEnumerable<IVariantUpdateAction> ActionsEnumerable { set => Actions = value.ToList(); }
    }
}
