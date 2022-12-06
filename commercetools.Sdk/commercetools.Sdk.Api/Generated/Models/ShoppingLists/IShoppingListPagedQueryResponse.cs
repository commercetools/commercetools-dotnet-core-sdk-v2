using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.ShoppingLists
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ShoppingLists.ShoppingListPagedQueryResponse))]
    public partial interface IShoppingListPagedQueryResponse
    {
        long Limit { get; set; }

        long Count { get; set; }

        long? Total { get; set; }

        long Offset { get; set; }

        IList<IShoppingList> Results { get; set; }
        IEnumerable<IShoppingList> ResultsEnumerable { set => Results = value.ToList(); }


    }
}
