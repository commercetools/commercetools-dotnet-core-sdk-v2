using System.Collections.Generic;


namespace commercetools.Api.Models.Orders
{
    public partial class OrderPagedQueryResponse : IOrderPagedQueryResponse
    {
        public long Limit { get; set;}
        
        public long Count { get; set;}
        
        public long? Total { get; set;}
        
        public long Offset { get; set;}
        
        public List<IOrder> Results { get; set;}
    }
}
