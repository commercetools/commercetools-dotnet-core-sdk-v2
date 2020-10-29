using commercetools.Api.Models.GraphQl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.GraphQl
{
    [DeserializeAs(typeof(commercetools.Api.Models.GraphQl.GraphQLError))]
    public interface IGraphQLError 
    {
        string Message { get; set;}
        
        List<IGraphQLErrorLocation> Locations { get; set;}
        
        List<Object> Path { get; set;}
    }
}
