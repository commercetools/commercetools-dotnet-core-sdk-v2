using commercetools.Api.Models.Messages;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    [DeserializeAs(typeof(commercetools.Api.Models.OrderEdits.OrderEditPreviewSuccess))]
    public partial interface IOrderEditPreviewSuccess : IOrderEditResult
    {
        IStagedOrder Preview { get; set; }

        List<IMessagePayload> MessagePayloads { get; set; }
    }
}
