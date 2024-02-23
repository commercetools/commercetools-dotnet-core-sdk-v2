using System.Linq;
using commercetools.Sdk.Api.Models.Errors;
using commercetools.Base.Client;

namespace commercetools.Sdk.Api.Extensions
{
    public static class ApiHttpExceptionExtensions
    {
        public static IErrorResponse AsErrorResponse(this ApiHttpException exception)
        {
            return exception.ResponseBody as IErrorResponse;
        }

        public static bool HasErrorCode(this IErrorResponse errorResponse, string errorCode)
        {
            return errorResponse.Errors.Any(o => o.Code.Equals(errorCode));
        }
    }
}