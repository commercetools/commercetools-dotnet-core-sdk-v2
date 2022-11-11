using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Errors.ErrorResponse))]
    public partial interface IErrorResponse
    {
        int StatusCode { get; set; }

        string Message { get; set; }

        List<IErrorObject> Errors { get; set; }

    }
}
