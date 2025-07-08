using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.ImportApi.Models.Common
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Common.CategoryKeyReference))]
    public partial interface ICategoryKeyReference : IKeyReference
    {
        new string Key { get; set; }

    }
}
