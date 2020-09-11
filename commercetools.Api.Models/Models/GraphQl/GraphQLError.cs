using commercetools.Api.Models.GraphQl;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.GraphQl
{
    public class GraphQLError 
    {
        public string Message { get; set;}
        
        public List<GraphQLErrorLocation> Locations { get; set;}
        
        public List<Object> Path { get; set;}
    }
}
