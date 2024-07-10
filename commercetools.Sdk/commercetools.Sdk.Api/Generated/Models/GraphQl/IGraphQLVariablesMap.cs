using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.GraphQl
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.GraphQl.GraphQLVariablesMap))]
    public interface IGraphQLVariablesMap : IDictionary<string, Object>
    {
    }
}
