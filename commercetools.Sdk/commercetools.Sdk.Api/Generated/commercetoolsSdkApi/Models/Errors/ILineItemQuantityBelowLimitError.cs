using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Errors.LineItemQuantityBelowLimitError))]
    public partial interface ILineItemQuantityBelowLimitError : IErrorObject
    {
        new string Code { get; set; }

        new string Message { get; set; }

        int Quantity { get; set; }

        int MinCartQuantity { get; set; }

        string LineItem { get; set; }

    }
}
