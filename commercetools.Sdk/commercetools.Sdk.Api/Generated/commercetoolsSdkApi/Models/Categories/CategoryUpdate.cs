using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.Api.Models.Categories
{

    public partial class CategoryUpdate : ICategoryUpdate
    {
        public long Version { get; set; }

        public IList<ICategoryUpdateAction> Actions { get; set; }

        public IEnumerable<ICategoryUpdateAction> ActionsEnumerable { set => Actions = value.ToList(); }
    }
}
