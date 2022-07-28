using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.GraphQl
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.GraphQl.GraphQLErrorLocation))]
    public partial interface IGraphQLErrorLocation
    {
        int Line { get; set; }

        int Column { get; set; }

    }
}
