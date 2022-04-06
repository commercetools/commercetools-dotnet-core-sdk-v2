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
    }
}