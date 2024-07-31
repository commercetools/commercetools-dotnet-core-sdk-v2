using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.Api.Models.GraphQl
{

    public partial class GraphQLResponse : IGraphQLResponse
    {
        public Object Data { get; set; }

        public IList<IGraphQLError> Errors { get; set; }

        public IEnumerable<IGraphQLError> ErrorsEnumerable { set => Errors = value.ToList(); }
    }
}
