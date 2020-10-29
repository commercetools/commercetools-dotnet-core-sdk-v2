using commercetools.Api.Models.GraphQl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.GraphQl
{
    [DeserializeAs(typeof(commercetools.Api.Models.GraphQl.GraphQLResponse))]
    public interface IGraphQLResponse 
    {
        Object Data { get; set;}
        
        List<IGraphQLError> Errors { get; set;}
    }
}
