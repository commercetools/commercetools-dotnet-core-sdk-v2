using System.Collections.Generic;


namespace commercetools.Api.Models.ShoppingLists
{
    public partial class ShoppingListPagedQueryResponse : IShoppingListPagedQueryResponse
    {
        public long Limit { get; set;}
        
        public long Count { get; set;}
        
        public long? Total { get; set;}
        
        public long Offset { get; set;}
        
        public List<IShoppingList> Results { get; set;}
    }
}
