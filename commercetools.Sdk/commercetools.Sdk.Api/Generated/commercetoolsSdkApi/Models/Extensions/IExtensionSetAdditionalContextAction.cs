using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Extensions
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Extensions.ExtensionSetAdditionalContextAction))]
    public partial interface IExtensionSetAdditionalContextAction : IExtensionUpdateAction
    {
        IExtensionAdditionalContextDraft AdditionalContext { get; set; }

    }
}
