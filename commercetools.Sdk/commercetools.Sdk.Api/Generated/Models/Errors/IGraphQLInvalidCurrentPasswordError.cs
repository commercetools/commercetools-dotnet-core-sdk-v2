using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Errors.GraphQLInvalidCurrentPasswordError))]
    public partial interface IGraphQLInvalidCurrentPasswordError : IGraphQLErrorObject
    {
        new string Code { get; set; }

    }
}
