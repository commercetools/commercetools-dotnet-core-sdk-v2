using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Errors.ExtensionError))]
    public partial interface IExtensionError
    {
        string Code { get; set; }

        string Message { get; set; }

        string ExtensionId { get; set; }

        string ExtensionKey { get; set; }

    }
}
