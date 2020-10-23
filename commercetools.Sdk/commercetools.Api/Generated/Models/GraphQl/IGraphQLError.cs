using commercetools.Api.Generated.Models.GraphQl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Generated.Models.GraphQl
{
    public interface IGraphQLError 
    {
        string Message { get; set;}
        
        List<IGraphQLErrorLocation> Locations { get; set;}
        
        List<Object> Path { get; set;}
    }
}
