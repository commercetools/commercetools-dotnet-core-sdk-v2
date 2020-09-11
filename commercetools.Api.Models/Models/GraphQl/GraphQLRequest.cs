using commercetools.Api.Models.GraphQl;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.GraphQl
{
    public class GraphQLRequest 
    {
        public string Query { get; set;}
        
        public string OperationName { get; set;}
        
        public GraphQLVariablesMap Variables { get; set;}
    }
}
