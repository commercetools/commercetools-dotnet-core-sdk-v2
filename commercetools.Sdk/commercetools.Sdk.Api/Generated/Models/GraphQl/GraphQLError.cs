using commercetools.Sdk.Api.Models.Errors;
using commercetools.Sdk.Api.Models.GraphQl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.GraphQl
{

    public partial class GraphQLError : IGraphQLError
    {
        public string Message { get; set; }

        public IList<IGraphQLErrorLocation> Locations { get; set; }
        public IEnumerable<IGraphQLErrorLocation> LocationsEnumerable { set => Locations = value.ToList(); }


        public IList<Object> Path { get; set; }
        public IEnumerable<Object> PathEnumerable { set => Path = value.ToList(); }


        public IGraphQLErrorObject Extensions { get; set; }
    }
}
