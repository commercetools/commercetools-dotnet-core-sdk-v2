using commercetools.Api.Models.GraphQl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.GraphQl
{
    public partial class GraphQLRequest 
    {
        public string Query { get; set;}
        
        public string OperationName { get; set;}
        
        public GraphQLVariablesMap Variables { get; set;}
    }
}
