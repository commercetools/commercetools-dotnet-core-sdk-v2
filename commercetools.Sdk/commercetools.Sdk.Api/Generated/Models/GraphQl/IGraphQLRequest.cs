using commercetools.Api.Models.GraphQl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.GraphQl
{
    [DeserializeAs(typeof(commercetools.Api.Models.GraphQl.GraphQLRequest))]
    public interface IGraphQLRequest 
    {
        string Query { get; set;}
        
        string OperationName { get; set;}
        
        IGraphQLVariablesMap Variables { get; set;}
    }
}
