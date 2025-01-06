using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.GraphQl
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.GraphQl.GraphQLErrorLocation))]
    public partial interface IGraphQLErrorLocation
    {
        long Line { get; set; }

        long Column { get; set; }

    }
}
