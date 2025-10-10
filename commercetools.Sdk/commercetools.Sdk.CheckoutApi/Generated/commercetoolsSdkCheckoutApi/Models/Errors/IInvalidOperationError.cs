using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.CheckoutApi.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Sdk.CheckoutApi.Models.Errors.InvalidOperationError))]
    public partial interface IInvalidOperationError : IErrorObject
    {
        new string Code { get; set; }

        new string Message { get; set; }

    }
}
