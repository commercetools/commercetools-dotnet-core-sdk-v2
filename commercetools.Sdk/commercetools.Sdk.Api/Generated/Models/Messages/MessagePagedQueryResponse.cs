using System.Collections.Generic;


namespace commercetools.Api.Models.Messages
{
    public partial class MessagePagedQueryResponse : IMessagePagedQueryResponse
    {
        public long Limit { get; set;}
        
        public long Count { get; set;}
        
        public long? Total { get; set;}
        
        public long Offset { get; set;}
        
        public List<IMessage> Results { get; set;}
    }
}
