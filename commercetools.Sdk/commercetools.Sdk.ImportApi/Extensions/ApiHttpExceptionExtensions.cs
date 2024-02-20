using System.Linq;
using commercetools.Base.Client;
using commercetools.Sdk.ImportApi.Models.Errors;

namespace commercetools.Sdk.ImportApi.Extensions
{
    public static class ApiHttpExceptionExtensions
    {
        public static IErrorResponse AsErrorResponse(this ApiHttpException exception)
        {
            return exception.ResponseBody as IErrorResponse;
        }
        
        public static bool HasErrorCode(this IErrorResponse errorResponse, string errorCode) {
            return errorResponse.Errors.Any(o => o.Code.Equals(errorCode));
        }
    }
}