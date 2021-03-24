using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    [TypeDiscriminator(nameof(Type))]
    [SubTypeDiscriminator("PreviewSuccess", typeof(commercetools.Api.Models.OrderEdits.OrderEditPreviewSuccess))]
    [SubTypeDiscriminator("Applied", typeof(commercetools.Api.Models.OrderEdits.OrderEditApplied))]
    [SubTypeDiscriminator("PreviewFailure", typeof(commercetools.Api.Models.OrderEdits.OrderEditPreviewFailure))]
    [SubTypeDiscriminator("NotProcessed", typeof(commercetools.Api.Models.OrderEdits.OrderEditNotProcessed))]
    public partial interface IOrderEditResult 
    {
        string Type { get; set;}
    }
}
