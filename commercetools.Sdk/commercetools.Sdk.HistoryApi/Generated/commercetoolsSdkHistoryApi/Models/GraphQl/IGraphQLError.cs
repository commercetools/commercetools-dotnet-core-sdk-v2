using commercetools.Sdk.HistoryApi.Models.Errors;
using System.Collections.Generic;
using System.Linq;
using System;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.GraphQl
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.GraphQl.GraphQLError))]
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
