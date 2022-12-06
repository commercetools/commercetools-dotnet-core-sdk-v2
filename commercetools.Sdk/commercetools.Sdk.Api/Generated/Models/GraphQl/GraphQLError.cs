using System;
using System.Collections.Generic;
using System.Linq;


namespace commercetools.Sdk.Api.Models.GraphQl
{

    public partial class GraphQLError : IGraphQLError
    {
        public string Message { get; set; }

        public IList<IGraphQLErrorLocation> Locations { get; set; }
        public IEnumerable<IGraphQLErrorLocation> LocationsEnumerable { set => Locations = value.ToList(); }


        public IList<Object> Path { get; set; }
        public IEnumerable<Object> PathEnumerable { set => Path = value.ToList(); }

    }
}
