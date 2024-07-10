using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.GraphQl
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.GraphQl.GraphQLErrorLocation))]
    public partial interface IGraphQLErrorLocation
    {
        int Line { get; set; }

        int Column { get; set; }

    }
}
