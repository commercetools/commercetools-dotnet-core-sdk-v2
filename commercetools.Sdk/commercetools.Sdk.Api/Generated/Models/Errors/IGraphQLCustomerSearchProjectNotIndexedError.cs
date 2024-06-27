using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Errors.GraphQLCustomerSearchProjectNotIndexedError))]
    public partial interface IGraphQLCustomerSearchProjectNotIndexedError : IGraphQLErrorObject
    {
        new string Code { get; set; }

    }
}
