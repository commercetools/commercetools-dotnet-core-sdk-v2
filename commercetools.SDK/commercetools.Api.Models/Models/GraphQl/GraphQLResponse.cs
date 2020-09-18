using commercetools.Api.Models.GraphQl;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.GraphQl
{
    public class GraphQLResponse 
    {
        public Object Data { get; set;}
        
        public List<GraphQLError> Errors { get; set;}
    }
}
