using commercetools.Api.Models.Errors;
using commercetools.Api.Models.OrderEdits;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    [DeserializeAs(typeof(commercetools.Api.Models.OrderEdits.OrderEditPreviewFailure))]
    public partial interface IOrderEditPreviewFailure : IOrderEditResult
    {
        List<IErrorObject> Errors { get; set;}
    }
}
