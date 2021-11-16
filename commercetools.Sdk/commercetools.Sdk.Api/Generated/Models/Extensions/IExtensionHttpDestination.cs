using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Extensions
{
    [DeserializeAs(typeof(commercetools.Api.Models.Extensions.ExtensionHttpDestination))]
    public partial interface IExtensionHttpDestination : IExtensionDestination
    {
        string Url { get; set; }

        IExtensionHttpDestinationAuthentication Authentication { get; set; }
    }
}
