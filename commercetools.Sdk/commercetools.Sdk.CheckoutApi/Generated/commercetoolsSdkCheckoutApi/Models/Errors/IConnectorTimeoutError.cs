using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.CheckoutApi.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Sdk.CheckoutApi.Models.Errors.ConnectorTimeoutError))]
    public partial interface IConnectorTimeoutError : IErrorObject
    {
        new string Code { get; set; }

        new string Message { get; set; }

    }
}
