using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.CheckoutApi.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Sdk.CheckoutApi.Models.Errors.SyntaxErrorError))]
    public partial interface ISyntaxErrorError : IErrorObject
    {
        new string Code { get; set; }

        new string Message { get; set; }

    }
}
