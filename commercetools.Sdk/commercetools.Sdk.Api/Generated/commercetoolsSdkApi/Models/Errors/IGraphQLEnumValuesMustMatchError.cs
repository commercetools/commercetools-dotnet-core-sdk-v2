using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Errors.GraphQLEnumValuesMustMatchError))]
    public partial interface IGraphQLEnumValuesMustMatchError : IGraphQLErrorObject
    {
        new string Code { get; set; }

    }
}
