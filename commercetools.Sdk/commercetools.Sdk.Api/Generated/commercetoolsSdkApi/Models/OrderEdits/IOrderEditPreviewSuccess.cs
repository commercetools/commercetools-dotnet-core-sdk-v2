using commercetools.Sdk.Api.Models.Messages;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.OrderEdits
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.OrderEdits.OrderEditPreviewSuccess))]
    public partial interface IOrderEditPreviewSuccess : IOrderEditResult
    {
        IStagedOrder Preview { get; set; }

        IList<IMessagePayload> MessagePayloads { get; set; }

        IEnumerable<IMessagePayload> MessagePayloadsEnumerable { set => MessagePayloads = value.ToList(); }

    }
}
