using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.GraphQl
{

    public partial class GraphQLErrorLocation : IGraphQLErrorLocation
    {
        public int Line { get; set; }

        public int Column { get; set; }
    }
}
