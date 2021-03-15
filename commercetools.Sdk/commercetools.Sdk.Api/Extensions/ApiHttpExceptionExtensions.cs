using commercetools.Api.Models.Errors;
using commercetools.Base.Client;
using commercetools.Base.Serialization;

namespace commercetools.Sdk.Api.Extensions
{
    public static class ApiHttpExceptionExtensions
    {
        public static IErrorResponse DeserializeAsErrorResponse(this ApiHttpException exception, ISerializerService serializerService)
        {
            return serializerService.Deserialize<ErrorResponse>(exception.Body);
        }
    }
}