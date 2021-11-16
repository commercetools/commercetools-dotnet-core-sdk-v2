namespace commercetools.Api.Models.GraphQl
{
    public partial class GraphQLErrorLocation : IGraphQLErrorLocation
    {
        public int Line { get; set;}
        
        public int Column { get; set;}
    }
}
