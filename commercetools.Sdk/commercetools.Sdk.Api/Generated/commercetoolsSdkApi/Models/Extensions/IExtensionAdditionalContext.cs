using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Extensions
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Extensions.ExtensionAdditionalContext))]
    public partial interface IExtensionAdditionalContext
    {
        bool IncludeOldResource { get; set; }

    }
}
