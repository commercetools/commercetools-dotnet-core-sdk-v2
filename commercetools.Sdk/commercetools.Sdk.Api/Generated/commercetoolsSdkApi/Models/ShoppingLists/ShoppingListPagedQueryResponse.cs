using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.Api.Models.ShoppingLists
{

    public partial class ShoppingListPagedQueryResponse : IShoppingListPagedQueryResponse
    {
        public long Limit { get; set; }

        public long Count { get; set; }

        public long? Total { get; set; }

        public long Offset { get; set; }

        public IList<IShoppingList> Results { get; set; }

        public IEnumerable<IShoppingList> ResultsEnumerable { set => Results = value.ToList(); }
    }
}
