using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.GraphQl
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.GraphQl.GraphQLRequest))]
    public partial interface IGraphQLRequest
    {
        string Query { get; set; }

        string OperationName { get; set; }

        IGraphQLVariablesMap Variables { get; set; }

    }
}
