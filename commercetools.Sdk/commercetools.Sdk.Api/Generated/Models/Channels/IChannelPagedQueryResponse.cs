using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Channels
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Channels.ChannelPagedQueryResponse))]
    public partial interface IChannelPagedQueryResponse
    {
        long Limit { get; set; }

        long Offset { get; set; }

        long Count { get; set; }

        long? Total { get; set; }

        IList<IChannel> Results { get; set; }
        IEnumerable<IChannel> ResultsEnumerable { set => Results = value.ToList(); }


    }
}
