using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Extensions
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Extensions.ExtensionChangeDestinationAction))]
    public partial interface IExtensionChangeDestinationAction : IExtensionUpdateAction
    {
        IExtensionDestination Destination { get; set; }

    }
}
