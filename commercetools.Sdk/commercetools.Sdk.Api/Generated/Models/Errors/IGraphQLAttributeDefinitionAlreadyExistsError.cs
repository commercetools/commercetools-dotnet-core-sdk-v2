using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Errors.GraphQLAttributeDefinitionAlreadyExistsError))]
    public partial interface IGraphQLAttributeDefinitionAlreadyExistsError : IGraphQLErrorObject
    {
        new string Code { get; set; }

        string ConflictingProductTypeId { get; set; }

        string ConflictingProductTypeName { get; set; }

        string ConflictingAttributeName { get; set; }

    }
}
