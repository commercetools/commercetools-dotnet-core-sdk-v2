using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.GraphQl
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.GraphQl.GraphQLErrorLocation))]
    public partial interface IGraphQLErrorLocation
    {
        long Line { get; set; }

        long Column { get; set; }

    }
}
