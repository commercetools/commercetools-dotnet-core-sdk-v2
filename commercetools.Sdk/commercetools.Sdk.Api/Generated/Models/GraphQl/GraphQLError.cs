using commercetools.Api.Models.GraphQl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.GraphQl
{
    public partial class GraphQLError : IGraphQLError
    {
        public string Message { get; set; }

        public List<IGraphQLErrorLocation> Locations { get; set; }

        public List<Object> Path { get; set; }
    }
}
