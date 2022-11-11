using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Errors.AuthErrorResponse))]
    public partial interface IAuthErrorResponse : IErrorResponse
    {
        string Error { get; set; }

        string Error_description { get; set; }

        new List<IErrorObject> Errors { get; set; }

    }
}
