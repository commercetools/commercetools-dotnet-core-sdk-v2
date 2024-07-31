using System;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;

namespace commercetools.Sdk.Api.Models.GraphQl
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.GraphQl.GraphQLVariablesMap))]
    public interface IGraphQLVariablesMap : IDictionary<string, Object>
    {
    }
}
