using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.Api.Models.TaxCategories
{

    public partial class TaxCategoryUpdate : ITaxCategoryUpdate
    {
        public long Version { get; set; }

        public IList<ITaxCategoryUpdateAction> Actions { get; set; }

        public IEnumerable<ITaxCategoryUpdateAction> ActionsEnumerable { set => Actions = value.ToList(); }
    }
}
