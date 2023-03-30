using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Errors.GraphQLReferencedResourceNotFoundError))]
    public partial interface IGraphQLReferencedResourceNotFoundError : IGraphQLErrorObject
    {
        new string Code { get; set; }

        IReferenceTypeId TypeId { get; set; }

        string Id { get; set; }

        string Key { get; set; }

    }
}
