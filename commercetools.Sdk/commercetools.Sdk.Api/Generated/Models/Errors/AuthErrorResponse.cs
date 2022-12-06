using System.Collections.Generic;


namespace commercetools.Sdk.Api.Models.Errors
{

    public partial class AuthErrorResponse : IAuthErrorResponse
    {
        public int StatusCode { get; set; }

        public string Message { get; set; }

        public List<IErrorObject> Errors { get; set; }

        public string Error { get; set; }

        public string Error_description { get; set; }
    }
}
