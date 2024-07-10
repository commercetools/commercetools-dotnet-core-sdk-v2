using commercetools.Sdk.Api.Models.GraphQl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.GraphQl
{

    public partial class GraphQLResponse : IGraphQLResponse
    {
        public Object Data { get; set; }

        public IList<IGraphQLError> Errors { get; set; }
        public IEnumerable<IGraphQLError> ErrorsEnumerable { set => Errors = value.ToList(); }

    }
}
