

namespace commercetools.Sdk.Api.Models.GraphQl
{

    public partial class GraphQLErrorLocation : IGraphQLErrorLocation
    {
        public long Line { get; set; }

        public long Column { get; set; }
    }
}
