using System.Collections.Generic;
using System.Linq;


namespace commercetools.Sdk.Api.Models.Products
{

    public partial class ProductUpdate : IProductUpdate
    {
        public long Version { get; set; }

        public IList<IProductUpdateAction> Actions { get; set; }
        public IEnumerable<IProductUpdateAction> ActionsEnumerable { set => Actions = value.ToList(); }

    }
}
