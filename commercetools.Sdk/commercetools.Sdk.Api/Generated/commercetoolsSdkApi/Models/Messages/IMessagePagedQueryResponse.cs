using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.MessagePagedQueryResponse))]
    public partial interface IMessagePagedQueryResponse
    {
        long Limit { get; set; }

        long Count { get; set; }

        long? Total { get; set; }

        long Offset { get; set; }

        IList<IMessage> Results { get; set; }

        IEnumerable<IMessage> ResultsEnumerable { set => Results = value.ToList(); }

    }
}
