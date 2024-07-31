using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Extensions
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Extensions.ExtensionSetKeyAction))]
    public partial interface IExtensionSetKeyAction : IExtensionUpdateAction
    {
        string Key { get; set; }

    }
}
