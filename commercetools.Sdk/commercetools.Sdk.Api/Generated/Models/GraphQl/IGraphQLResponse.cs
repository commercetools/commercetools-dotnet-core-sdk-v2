using System;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.GraphQl
{
    [DeserializeAs(typeof(commercetools.Api.Models.GraphQl.GraphQLResponse))]
    public partial interface IGraphQLResponse 
    {
        Object Data { get; set;}
        
        List<IGraphQLError> Errors { get; set;}
    }
}
