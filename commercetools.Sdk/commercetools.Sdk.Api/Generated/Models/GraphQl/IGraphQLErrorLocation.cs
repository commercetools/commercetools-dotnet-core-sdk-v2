using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.GraphQl
{
    [DeserializeAs(typeof(commercetools.Api.Models.GraphQl.GraphQLErrorLocation))]
    public interface IGraphQLErrorLocation 
    {
        int Line { get; set;}
        
        int Column { get; set;}
    }
}
