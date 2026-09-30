using commercetools.Sdk.Api.Models.Errors;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Agents
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Agents.GraphQLAgentStoreUnresolvedError))]
    public partial interface IGraphQLAgentStoreUnresolvedError : IGraphQLErrorObject
    {
        new string Code { get; set; }

    }
}
