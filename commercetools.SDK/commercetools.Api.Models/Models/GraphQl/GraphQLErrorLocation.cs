using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.GraphQl
{
    public class GraphQLErrorLocation 
    {
        public int Line { get; set;}
        
        public int Column { get; set;}
    }
}
