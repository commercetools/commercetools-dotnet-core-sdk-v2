using commercetools.Sdk.Api.Models.Errors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Errors
{

    public partial class AuthErrorResponse : IAuthErrorResponse
    {
        public int StatusCode { get; set; }

        public string Message { get; set; }

        public IList<IErrorObject> Errors { get; set; }
        public IEnumerable<IErrorObject> ErrorsEnumerable { set => Errors = value.ToList(); }


        public string Error { get; set; }

        public string Error_description { get; set; }
    }
}
