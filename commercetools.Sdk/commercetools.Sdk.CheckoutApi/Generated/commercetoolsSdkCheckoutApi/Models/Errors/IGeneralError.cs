using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.CheckoutApi.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Sdk.CheckoutApi.Models.Errors.GeneralError))]
    public partial interface IGeneralError : IErrorObject
    {
        new string Code { get; set; }

        new string Message { get; set; }

    }
}
