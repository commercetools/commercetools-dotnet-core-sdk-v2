using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Errors.AuthErrorResponse))]
    public partial interface IAuthErrorResponse : IErrorResponse
    {
        string Error { get; set; }

        string Error_description { get; set; }

        new IList<IErrorObject> Errors { get; set; }
        new IEnumerable<IErrorObject> ErrorsEnumerable { set => Errors = value.ToList(); }


    }
}
