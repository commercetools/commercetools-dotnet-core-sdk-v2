using System.Collections.Generic;
using System.Linq;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class MessagePagedQueryResponse : IMessagePagedQueryResponse
    {
        public long Limit { get; set; }

        public long Count { get; set; }

        public long? Total { get; set; }

        public long Offset { get; set; }

        public IList<IMessage> Results { get; set; }
        public IEnumerable<IMessage> ResultsEnumerable { set => Results = value.ToList(); }

    }
}
