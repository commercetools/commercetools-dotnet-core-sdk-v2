using System;
using System.Collections.Generic;


namespace commercetools.Sdk.Api.Models.GraphQl
{
    public partial class GraphQLError : IGraphQLError
    {
        public string Message { get; set; }

        public List<IGraphQLErrorLocation> Locations { get; set; }

        public List<Object> Path { get; set; }
    }
}
