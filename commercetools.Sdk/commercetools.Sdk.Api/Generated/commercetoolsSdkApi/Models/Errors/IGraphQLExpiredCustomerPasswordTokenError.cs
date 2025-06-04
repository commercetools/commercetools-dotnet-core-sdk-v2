using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Errors.GraphQLExpiredCustomerPasswordTokenError))]
    public partial interface IGraphQLExpiredCustomerPasswordTokenError : IGraphQLErrorObject
    {
        new string Code { get; set; }

    }
}
