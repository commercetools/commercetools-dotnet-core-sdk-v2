using System.Collections.Generic;
using System.Linq;


namespace commercetools.Sdk.Api.Models.Channels
{

    public partial class ChannelPagedQueryResponse : IChannelPagedQueryResponse
    {
        public long Limit { get; set; }

        public long Offset { get; set; }

        public long Count { get; set; }

        public long? Total { get; set; }

        public IList<IChannel> Results { get; set; }
        public IEnumerable<IChannel> ResultsEnumerable { set => Results = value.ToList(); }

    }
}
