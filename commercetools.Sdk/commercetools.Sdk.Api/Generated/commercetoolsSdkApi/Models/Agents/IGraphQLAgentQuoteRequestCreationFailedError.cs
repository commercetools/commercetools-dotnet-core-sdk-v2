using commercetools.Sdk.Api.Models.Errors;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Agents
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Agents.GraphQLAgentQuoteRequestCreationFailedError))]
    public partial interface IGraphQLAgentQuoteRequestCreationFailedError : IGraphQLErrorObject
    {
        new string Code { get; set; }

        string CartId { get; set; }

    }
}
