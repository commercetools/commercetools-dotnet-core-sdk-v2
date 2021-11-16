using System.Collections.Generic;


namespace commercetools.Api.Models.Stores
{
    public partial class StorePagedQueryResponse : IStorePagedQueryResponse
    {
        public long Limit { get; set;}
        
        public long Count { get; set;}
        
        public long? Total { get; set;}
        
        public long Offset { get; set;}
        
        public List<IStore> Results { get; set;}
    }
}
