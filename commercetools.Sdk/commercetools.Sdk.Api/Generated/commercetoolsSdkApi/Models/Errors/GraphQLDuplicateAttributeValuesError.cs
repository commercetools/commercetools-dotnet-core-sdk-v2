using commercetools.Sdk.Api.Models.Products;
using System.Collections.Generic;
using System.Linq;


namespace commercetools.Sdk.Api.Models.Errors
{

    public partial class GraphQLDuplicateAttributeValuesError : IGraphQLDuplicateAttributeValuesError
    {
        public string Code { get; set; }

        public IList<IAttribute> Attributes { get; set; }
        public IEnumerable<IAttribute> AttributesEnumerable { set => Attributes = value.ToList(); }

        public GraphQLDuplicateAttributeValuesError()
        {
            this.Code = "DuplicateAttributeValues";
        }
    }
}
