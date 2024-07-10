using commercetools.Sdk.Api.Models.Errors;
using commercetools.Sdk.Api.Models.GraphQl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.GraphQl
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.GraphQl.GraphQLError))]
    public partial interface IGraphQLError
    {
        string Message { get; set; }

        IList<IGraphQLErrorLocation> Locations { get; set; }
        IEnumerable<IGraphQLErrorLocation> LocationsEnumerable { set => Locations = value.ToList(); }


        IList<Object> Path { get; set; }
        IEnumerable<Object> PathEnumerable { set => Path = value.ToList(); }


        IGraphQLErrorObject Extensions { get; set; }

    }
}
