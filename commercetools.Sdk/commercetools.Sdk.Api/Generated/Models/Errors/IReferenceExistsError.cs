using commercetools.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Api.Models.Errors.ReferenceExistsError))]
    public partial interface IReferenceExistsError : IErrorObject
    {
        IReferenceTypeId ReferencedBy { get; set; }
    }
}
