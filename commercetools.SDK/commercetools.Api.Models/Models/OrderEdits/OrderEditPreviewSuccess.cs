using commercetools.Api.Models.Messages;
using commercetools.Api.Models.OrderEdits;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    [DiscriminatorValue("PreviewSuccess")]
    public class OrderEditPreviewSuccess : OrderEditResult
    {
        public StagedOrder Preview { get; set;}
        
        public List<MessagePayload> MessagePayloads { get; set;}
    }
}
