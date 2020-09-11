using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.GraphQl
{
    public class GraphQLErrorLocation 
    {
        public int Line { get; set;}
        
        public int Column { get; set;}
    }
}
