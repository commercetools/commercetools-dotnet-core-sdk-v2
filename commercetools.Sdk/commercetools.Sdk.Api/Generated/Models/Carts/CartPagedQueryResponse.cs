using System.Collections.Generic;


namespace commercetools.Api.Models.Carts
{
    public partial class CartPagedQueryResponse : ICartPagedQueryResponse
    {
        public long Limit { get; set;}
        
        public long Count { get; set;}
        
        public long? Total { get; set;}
        
        public long Offset { get; set;}
        
        public List<ICart> Results { get; set;}
    }
}
