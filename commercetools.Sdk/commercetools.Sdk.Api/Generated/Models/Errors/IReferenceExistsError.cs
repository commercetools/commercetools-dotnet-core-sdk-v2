using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Errors.ReferenceExistsError))]
    public partial interface IReferenceExistsError : IErrorObject
    {
        IReferenceTypeId ReferencedBy { get; set; }
    }
}
