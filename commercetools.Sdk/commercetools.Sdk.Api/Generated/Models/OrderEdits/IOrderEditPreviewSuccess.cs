using commercetools.Api.Models.Messages;
using commercetools.Api.Models.OrderEdits;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
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
