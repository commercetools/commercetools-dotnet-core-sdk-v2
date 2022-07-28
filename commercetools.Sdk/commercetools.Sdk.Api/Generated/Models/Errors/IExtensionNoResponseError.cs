using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Errors.ExtensionNoResponseError))]
    public partial interface IExtensionNoResponseError : IErrorObject
    {
        string ExtensionId { get; set; }

        string ExtensionKey { get; set; }

    }
}
