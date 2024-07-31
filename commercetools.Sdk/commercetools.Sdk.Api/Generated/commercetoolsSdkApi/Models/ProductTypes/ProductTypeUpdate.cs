using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.Api.Models.ProductTypes
{

    public partial class ProductTypeUpdate : IProductTypeUpdate
    {
        public long Version { get; set; }

        public IList<IProductTypeUpdateAction> Actions { get; set; }

        public IEnumerable<IProductTypeUpdateAction> ActionsEnumerable { set => Actions = value.ToList(); }
    }
}
