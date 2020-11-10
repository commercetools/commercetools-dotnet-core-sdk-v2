using commercetools.Api.Models.Errors;
using commercetools.Api.Models.OrderEdits;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Api.Models.Errors.EditPreviewFailedError))]
    public partial interface IEditPreviewFailedError : IErrorObject
    {
        IOrderEditPreviewFailure Result { get; set;}
    }
}
