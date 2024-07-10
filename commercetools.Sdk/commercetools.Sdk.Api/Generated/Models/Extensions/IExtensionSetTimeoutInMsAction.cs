using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Extensions
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Extensions.ExtensionSetTimeoutInMsAction))]
    public partial interface IExtensionSetTimeoutInMsAction : IExtensionUpdateAction
    {
        int? TimeoutInMs { get; set; }

    }
}
