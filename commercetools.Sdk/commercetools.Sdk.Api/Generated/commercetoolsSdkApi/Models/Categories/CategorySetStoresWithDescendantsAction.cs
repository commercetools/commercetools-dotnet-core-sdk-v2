using commercetools.Sdk.Api.Models.Stores;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.Api.Models.Categories
{

    public partial class CategorySetStoresWithDescendantsAction : ICategorySetStoresWithDescendantsAction
    {
        public string Action { get; set; }

        public IList<IStoreResourceIdentifier> Stores { get; set; }

        public IEnumerable<IStoreResourceIdentifier> StoresEnumerable { set => Stores = value.ToList(); }
        public CategorySetStoresWithDescendantsAction()
        {
            this.Action = "setStoresWithDescendants";
        }
    }
}
