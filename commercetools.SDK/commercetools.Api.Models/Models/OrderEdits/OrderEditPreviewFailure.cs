using commercetools.Api.Models.Errors;
using commercetools.Api.Models.OrderEdits;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    [DiscriminatorValue("PreviewFailure")]
    public partial class OrderEditPreviewFailure : OrderEditResult
    {
        public List<ErrorObject> Errors { get; set;}
        public OrderEditPreviewFailure()
        { 
           this.Type = "PreviewFailure";
        }
    }
}
