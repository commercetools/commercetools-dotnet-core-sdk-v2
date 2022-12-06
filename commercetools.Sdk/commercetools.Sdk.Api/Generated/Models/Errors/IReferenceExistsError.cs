using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Errors.ReferenceExistsError))]
    public partial interface IReferenceExistsError : IErrorObject
    {
        new string Code { get; set; }

        new string Message { get; set; }

        IReferenceTypeId ReferencedBy { get; set; }

    }
}
