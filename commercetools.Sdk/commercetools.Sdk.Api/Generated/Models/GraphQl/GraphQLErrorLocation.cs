using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.GraphQl
{
    public  partial class GraphQLErrorLocation : IGraphQLErrorLocation
    {
        public int Line { get; set;}
        
        public int Column { get; set;}
    }
}
