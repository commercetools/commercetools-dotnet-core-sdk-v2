using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Extensions
{
    [DeserializeAs(typeof(commercetools.Api.Models.Extensions.ExtensionChangeDestinationAction))]
    public partial interface IExtensionChangeDestinationAction : IExtensionUpdateAction
    {
        IExtensionDestination Destination { get; set;}
    }
}
