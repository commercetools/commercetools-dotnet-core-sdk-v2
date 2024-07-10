using commercetools.Sdk.Api.Models.Errors;
using commercetools.Sdk.Api.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


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
