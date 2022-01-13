using System;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.GraphQl
{
    [DeserializeAs(typeof(commercetools.Api.Models.GraphQl.GraphQLVariablesMap))]
    public interface IGraphQLVariablesMap : IDictionary<string, Object>
    {
    }
}
