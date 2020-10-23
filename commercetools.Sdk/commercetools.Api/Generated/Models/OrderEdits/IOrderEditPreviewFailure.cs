using commercetools.Api.Generated.Models.Errors;
using commercetools.Api.Generated.Models.OrderEdits;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Generated.Models.OrderEdits
{
    public interface IOrderEditPreviewFailure : IOrderEditResult
    {
        List<IErrorObject> Errors { get; set;}
    }
}
