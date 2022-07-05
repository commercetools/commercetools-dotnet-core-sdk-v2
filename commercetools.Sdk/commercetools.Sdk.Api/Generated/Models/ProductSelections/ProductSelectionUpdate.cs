using System.Collections.Generic;


namespace commercetools.Sdk.Api.Models.ProductSelections
{

    public partial class ProductSelectionUpdate : IProductSelectionUpdate
    {
        public long Version { get; set; }

        public List<IProductSelectionUpdateAction> Actions { get; set; }
    }
}
