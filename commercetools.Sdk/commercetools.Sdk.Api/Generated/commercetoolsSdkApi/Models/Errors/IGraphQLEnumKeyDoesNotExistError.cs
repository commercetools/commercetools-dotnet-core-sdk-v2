using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Errors.GraphQLEnumKeyDoesNotExistError))]
    public partial interface IGraphQLEnumKeyDoesNotExistError : IGraphQLErrorObject
    {
        new string Code { get; set; }

        string ConflictingEnumKey { get; set; }

        string ConflictingAttributeName { get; set; }

    }
}
