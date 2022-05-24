using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Extensions
{
    [TypeDiscriminator(nameof(Action))]
    [DefaultTypeDiscriminator(typeof(commercetools.Sdk.Api.Models.Extensions.ExtensionUpdateAction))]
    [SubTypeDiscriminator("changeDestination", typeof(commercetools.Sdk.Api.Models.Extensions.ExtensionChangeDestinationAction))]
    [SubTypeDiscriminator("changeTriggers", typeof(commercetools.Sdk.Api.Models.Extensions.ExtensionChangeTriggersAction))]
    [SubTypeDiscriminator("setKey", typeof(commercetools.Sdk.Api.Models.Extensions.ExtensionSetKeyAction))]
    [SubTypeDiscriminator("setTimeoutInMs", typeof(commercetools.Sdk.Api.Models.Extensions.ExtensionSetTimeoutInMsAction))]
    public partial interface IExtensionUpdateAction : commercetools.Sdk.Api.Models.IResourceUpdateAction<IExtensionUpdateAction>
    {
        new string Action { get; set; }
    }
}
