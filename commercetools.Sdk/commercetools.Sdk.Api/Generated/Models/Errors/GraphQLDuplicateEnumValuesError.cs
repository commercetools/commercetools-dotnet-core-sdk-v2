using commercetools.Sdk.Api.Models.Errors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Errors
{

    public partial class GraphQLDuplicateEnumValuesError : IGraphQLDuplicateEnumValuesError
    {
        public string Code { get; set; }

        public IList<string> Duplicates { get; set; }
        public IEnumerable<string> DuplicatesEnumerable { set => Duplicates = value.ToList(); }

        public GraphQLDuplicateEnumValuesError()
        {
            this.Code = "DuplicateEnumValues";
        }
    }
}
