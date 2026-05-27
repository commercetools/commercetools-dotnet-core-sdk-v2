using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Errors.LineItemQuantityAboveLimitError))]
    public partial interface ILineItemQuantityAboveLimitError : IErrorObject
    {
        new string Code { get; set; }

        new string Message { get; set; }

        int Quantity { get; set; }

        int MaxCartQuantity { get; set; }

        string LineItem { get; set; }

    }
}
