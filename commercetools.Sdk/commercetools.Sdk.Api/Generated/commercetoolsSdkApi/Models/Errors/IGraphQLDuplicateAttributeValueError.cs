using commercetools.Sdk.Api.Models.Products;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Errors.GraphQLDuplicateAttributeValueError))]
    public partial interface IGraphQLDuplicateAttributeValueError : IGraphQLErrorObject
    {
        new string Code { get; set; }

        IAttribute Attribute { get; set; }

    }
}
