using System;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;

namespace commercetools.Sdk.HistoryApi.Models.GraphQl
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.GraphQl.GraphQLVariablesMap))]
    public partial interface IGraphQLVariablesMap : IDictionary<string, Object>
    {
    }
}
