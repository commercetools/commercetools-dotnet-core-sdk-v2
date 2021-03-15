using commercetools.Base.Client;
using commercetools.Base.Serialization;
using commercetools.ImportApi.Models.Errors;

namespace commercetools.Sdk.ImportApi.Extensions
{
    public static class ApiHttpExceptionExtensions
    {
        public static IErrorResponse DeserializeAsErrorResponse(this ApiHttpException exception, ISerializerService serializerService)
        {
            return serializerService.Deserialize<ErrorResponse>(exception.Body);
        }
    }
}