using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Errors.GraphQLSearchNotReadyError))]
    public partial interface IGraphQLSearchNotReadyError : IGraphQLErrorObject
    {
        new string Code { get; set; }

    }
}
