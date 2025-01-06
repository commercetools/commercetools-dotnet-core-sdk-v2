using System;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;

namespace commercetools.Sdk.HistoryApi.Models.GraphQl
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.GraphQl.GraphQLVariablesMap))]
    public interface IGraphQLVariablesMap : IDictionary<string, Object>
    {
    }
}
