using commercetools.Api.Models.GraphQl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.GraphQl
{
    public partial class GraphQLResponse 
    {
        public Object Data { get; set;}
        
        public List<GraphQLError> Errors { get; set;}
    }
}
