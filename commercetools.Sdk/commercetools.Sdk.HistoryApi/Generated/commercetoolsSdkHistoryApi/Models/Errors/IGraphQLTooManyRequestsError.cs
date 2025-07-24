using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Errors.GraphQLTooManyRequestsError))]
    public partial interface IGraphQLTooManyRequestsError : IGraphQLErrorObject
    {
        new string Code { get; set; }

    }
}
