using commercetools.Api.Models.GraphQl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.GraphQl
{
    public partial class GraphQLRequest : IGraphQLRequest
    {
        public string Query { get; set; }

        public string OperationName { get; set; }

        public IGraphQLVariablesMap Variables { get; set; }
    }
}
