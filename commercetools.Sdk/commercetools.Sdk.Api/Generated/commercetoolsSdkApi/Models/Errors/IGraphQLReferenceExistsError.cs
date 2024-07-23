using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Errors.GraphQLReferenceExistsError))]
    public partial interface IGraphQLReferenceExistsError : IGraphQLErrorObject
    {
        new string Code { get; set; }

        IReferenceTypeId ReferencedBy { get; set; }

    }
}
