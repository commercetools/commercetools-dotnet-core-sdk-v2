using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    [TypeDiscriminator(nameof(Type))]
    [SubTypeDiscriminator("PreviewSuccess", typeof(commercetools.Api.Models.OrderEdits.OrderEditPreviewSuccess))]
    [SubTypeDiscriminator("NotProcessed", typeof(commercetools.Api.Models.OrderEdits.OrderEditNotProcessed))]
    [SubTypeDiscriminator("Applied", typeof(commercetools.Api.Models.OrderEdits.OrderEditApplied))]
    [SubTypeDiscriminator("PreviewFailure", typeof(commercetools.Api.Models.OrderEdits.OrderEditPreviewFailure))]
    public interface IOrderEditResult 
    {
        string Type { get; set;}
    }
}
