using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Errors.ReferencedResourceNotFoundError))]
    public partial interface IReferencedResourceNotFoundError : IErrorObject
    {
        IReferenceTypeId TypeId { get; set; }

        string Id { get; set; }

        string Key { get; set; }
    }
}
