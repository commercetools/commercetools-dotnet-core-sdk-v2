using System.Collections.Generic;
using System.Linq;


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
