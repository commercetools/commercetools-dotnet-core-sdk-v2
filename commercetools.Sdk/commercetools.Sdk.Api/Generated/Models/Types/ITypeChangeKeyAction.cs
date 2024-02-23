using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Types
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Types.TypeChangeKeyAction))]
    public partial interface ITypeChangeKeyAction : ITypeUpdateAction
    {
        string Key { get; set; }

    }
}
