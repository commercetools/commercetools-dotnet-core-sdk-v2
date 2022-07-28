using System;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.GraphQl
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.GraphQl.GraphQLError))]
    public partial interface IGraphQLError
    {
        string Message { get; set; }

        List<IGraphQLErrorLocation> Locations { get; set; }

        List<Object> Path { get; set; }

    }
}
