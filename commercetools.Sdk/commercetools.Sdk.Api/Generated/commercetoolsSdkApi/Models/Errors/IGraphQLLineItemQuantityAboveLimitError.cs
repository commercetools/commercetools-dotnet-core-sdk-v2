using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Errors.GraphQLLineItemQuantityAboveLimitError))]
    public partial interface IGraphQLLineItemQuantityAboveLimitError : IGraphQLErrorObject
    {
        new string Code { get; set; }

        int Quantity { get; set; }

        int MaxCartQuantity { get; set; }

        string LineItem { get; set; }

    }
}
