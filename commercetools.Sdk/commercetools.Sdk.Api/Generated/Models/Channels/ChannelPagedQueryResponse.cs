using System.Collections.Generic;


namespace commercetools.Api.Models.Channels
{
    public partial class ChannelPagedQueryResponse : IChannelPagedQueryResponse
    {
        public long Limit { get; set; }

        public long Count { get; set; }

        public long? Total { get; set; }

        public long Offset { get; set; }

        public List<IChannel> Results { get; set; }
    }
}
