using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Extensions
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Extensions.HttpDestination))]
    public partial interface IHttpDestination : IExtensionDestination
    {
        string Url { get; set; }

        IHttpDestinationAuthentication Authentication { get; set; }
    }
}
