using System;
using System.Collections.Generic;


namespace commercetools.Api.Models.GraphQl
{
    public partial class GraphQLResponse : IGraphQLResponse
    {
        public Object Data { get; set;}
        
        public List<IGraphQLError> Errors { get; set;}
    }
}
