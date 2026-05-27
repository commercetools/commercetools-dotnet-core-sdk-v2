using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Errors.GraphQLLineItemQuantityBelowLimitError))]
    public partial interface IGraphQLLineItemQuantityBelowLimitError : IGraphQLErrorObject
    {
        new string Code { get; set; }

        int Quantity { get; set; }

        int MinCartQuantity { get; set; }

        string LineItem { get; set; }

    }
}
