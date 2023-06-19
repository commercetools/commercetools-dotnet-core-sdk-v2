using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Errors.GraphQLNotEnabledError))]
    public partial interface IGraphQLNotEnabledError : IGraphQLErrorObject
    {
        new string Code { get; set; }

    }
}
