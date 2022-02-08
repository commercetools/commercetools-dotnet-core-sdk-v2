using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Extensions
{
    [DeserializeAs(typeof(commercetools.Api.Models.Extensions.HttpDestination))]
    public partial interface IHttpDestination : IExtensionDestination
    {
        string Url { get; set; }

        IHttpDestinationAuthentication Authentication { get; set; }
    }
}
