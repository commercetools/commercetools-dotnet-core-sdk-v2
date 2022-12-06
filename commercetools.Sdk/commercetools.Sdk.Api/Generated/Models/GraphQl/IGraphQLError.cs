using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;


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


    }
}
