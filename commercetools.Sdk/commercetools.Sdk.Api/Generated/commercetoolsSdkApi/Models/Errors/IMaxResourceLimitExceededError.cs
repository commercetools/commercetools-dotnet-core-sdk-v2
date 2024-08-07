using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Errors.MaxResourceLimitExceededError))]
    public partial interface IMaxResourceLimitExceededError : IErrorObject
    {
        new string Code { get; set; }

        new string Message { get; set; }

        IReferenceTypeId ExceededResource { get; set; }

    }
}
