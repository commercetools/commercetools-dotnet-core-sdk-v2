using System.Collections.Generic;
using System.Linq;


namespace commercetools.Sdk.Api.Models.ProductSelections
{

    public partial class ProductSelectionUpdate : IProductSelectionUpdate
    {
        public long Version { get; set; }

        public IList<IProductSelectionUpdateAction> Actions { get; set; }
        public IEnumerable<IProductSelectionUpdateAction> ActionsEnumerable { set => Actions = value.ToList(); }

    }
}
