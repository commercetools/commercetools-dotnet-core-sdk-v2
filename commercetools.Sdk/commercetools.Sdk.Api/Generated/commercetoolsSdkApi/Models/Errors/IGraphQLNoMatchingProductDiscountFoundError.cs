using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Errors.GraphQLNoMatchingProductDiscountFoundError))]
    public partial interface IGraphQLNoMatchingProductDiscountFoundError : IGraphQLErrorObject
    {
        new string Code { get; set; }

    }
}
