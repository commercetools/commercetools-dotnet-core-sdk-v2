using commercetools.Sdk.Api.Models.Messages;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.OrderEdits
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.OrderEdits.OrderEditPreviewSuccess))]
    public partial interface IOrderEditPreviewSuccess : IOrderEditResult
    {
        IStagedOrder Preview { get; set; }

        List<IMessagePayload> MessagePayloads { get; set; }

    }
}
