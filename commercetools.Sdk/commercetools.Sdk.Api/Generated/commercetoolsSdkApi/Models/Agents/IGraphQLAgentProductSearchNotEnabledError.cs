using commercetools.Sdk.Api.Models.Errors;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Agents
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Agents.GraphQLAgentProductSearchNotEnabledError))]
    public partial interface IGraphQLAgentProductSearchNotEnabledError : IGraphQLErrorObject
    {
        new string Code { get; set; }

    }
}
