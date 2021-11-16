using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Extensions
{
    [DeserializeAs(typeof(commercetools.Api.Models.Extensions.ExtensionSetTimeoutInMsAction))]
    public partial interface IExtensionSetTimeoutInMsAction : IExtensionUpdateAction
    {
        int? TimeoutInMs { get; set; }
    }
}
