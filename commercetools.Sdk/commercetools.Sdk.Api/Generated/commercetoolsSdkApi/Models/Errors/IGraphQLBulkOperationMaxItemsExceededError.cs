using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Errors.GraphQLBulkOperationMaxItemsExceededError))]
    public partial interface IGraphQLBulkOperationMaxItemsExceededError : IGraphQLErrorObject
    {
        new string Code { get; set; }

        int Limit { get; set; }

        int Provided { get; set; }

    }
}
