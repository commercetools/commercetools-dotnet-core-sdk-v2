using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Extensions
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Extensions.ExtensionSetTimeoutInMsAction))]
    public partial interface IExtensionSetTimeoutInMsAction : IExtensionUpdateAction
    {
        int? TimeoutInMs { get; set; }

    }
}
