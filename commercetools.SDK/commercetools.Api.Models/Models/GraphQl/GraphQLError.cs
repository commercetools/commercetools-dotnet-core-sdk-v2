using commercetools.Api.Models.GraphQl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.GraphQl
{
    public partial class GraphQLError 
    {
        public string Message { get; set;}
        
        public List<GraphQLErrorLocation> Locations { get; set;}
        
        public List<Object> Path { get; set;}
    }
}
