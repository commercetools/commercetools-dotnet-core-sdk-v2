using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Extensions
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Extensions.ExtensionAdditionalContextDraft))]
    public partial interface IExtensionAdditionalContextDraft
    {
        bool? IncludeOldResource { get; set; }

    }
}
