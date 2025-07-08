using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.ImportApi.Models.Common
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Common.TypeKeyReference))]
    public partial interface ITypeKeyReference : IKeyReference
    {
        new string Key { get; set; }

    }
}
