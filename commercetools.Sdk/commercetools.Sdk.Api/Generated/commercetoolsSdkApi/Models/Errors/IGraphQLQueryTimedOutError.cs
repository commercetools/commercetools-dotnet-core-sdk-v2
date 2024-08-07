using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Errors.GraphQLQueryTimedOutError))]
    public partial interface IGraphQLQueryTimedOutError : IGraphQLErrorObject
    {
        new string Code { get; set; }

    }
}
