using commercetools.Api.Models.Messages;
using commercetools.Api.Models.OrderEdits;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    [DiscriminatorValue("PreviewSuccess")]
    public partial class OrderEditPreviewSuccess : OrderEditResult
    {
        public StagedOrder Preview { get; set;}
        
        public List<MessagePayload> MessagePayloads { get; set;}
        public OrderEditPreviewSuccess()
        { 
           this.Type = "PreviewSuccess";
        }
    }
}
