using System.Collections.Generic;


namespace commercetools.Api.Models.CartDiscounts
{
    public partial class CartDiscountPagedQueryResponse : ICartDiscountPagedQueryResponse
    {
        public long Limit { get; set;}
        
        public long Count { get; set;}
        
        public long? Total { get; set;}
        
        public long Offset { get; set;}
        
        public List<ICartDiscount> Results { get; set;}
    }
}
