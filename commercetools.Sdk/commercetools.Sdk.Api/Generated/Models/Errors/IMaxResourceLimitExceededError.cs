using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Errors.MaxResourceLimitExceededError))]
    public partial interface IMaxResourceLimitExceededError : IErrorObject
    {
        IReferenceTypeId ExceededResource { get; set; }
    }
}
