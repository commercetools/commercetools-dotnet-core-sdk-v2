using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Errors.GraphQLExpiredCustomerEmailTokenError))]
    public partial interface IGraphQLExpiredCustomerEmailTokenError : IGraphQLErrorObject
    {
        new string Code { get; set; }

    }
}
