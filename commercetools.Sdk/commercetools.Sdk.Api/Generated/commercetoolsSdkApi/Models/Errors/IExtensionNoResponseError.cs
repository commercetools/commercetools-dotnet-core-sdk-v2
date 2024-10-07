using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Errors.ExtensionNoResponseError))]
    public partial interface IExtensionNoResponseError : IErrorObject
    {
        new string Code { get; set; }

        new string Message { get; set; }

        string ExtensionId { get; set; }

        string ExtensionKey { get; set; }

    }
}
