using commercetools.Sdk.Api.Models.Errors;
using commercetools.Base.Client;

namespace commercetools.Sdk.Api.Extensions
{
    public static class ApiHttpExceptionExtensions
    {
        public static IErrorResponse AsErrorResponse(this ApiHttpException exception)
        {
            return exception.ResponseBody as ErrorResponse;
        }
    }
}