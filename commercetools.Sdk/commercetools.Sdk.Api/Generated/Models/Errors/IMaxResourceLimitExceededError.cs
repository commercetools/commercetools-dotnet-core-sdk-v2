using commercetools.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Api.Models.Errors.MaxResourceLimitExceededError))]
    public partial interface IMaxResourceLimitExceededError : IErrorObject
    {
        IReferenceTypeId ExceededResource { get; set;}
    }
}
