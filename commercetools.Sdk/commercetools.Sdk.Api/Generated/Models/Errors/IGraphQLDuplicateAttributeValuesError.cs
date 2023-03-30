using commercetools.Sdk.Api.Models.Products;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Errors.GraphQLDuplicateAttributeValuesError))]
    public partial interface IGraphQLDuplicateAttributeValuesError : IGraphQLErrorObject
    {
        new string Code { get; set; }

        IList<IAttribute> Attributes { get; set; }
        IEnumerable<IAttribute> AttributesEnumerable { set => Attributes = value.ToList(); }


    }
}
