using commercetools.Api.Models.GraphQl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.GraphQl
{
    public  partial class GraphQLResponse : IGraphQLResponse
    {
        public Object Data { get; set;}
        
        public List<IGraphQLError> Errors { get; set;}
    }
}
