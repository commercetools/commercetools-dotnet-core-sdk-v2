using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.ImportApi.Models.Common
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Common.ProductVariantKeyReference))]
    public partial interface IProductVariantKeyReference : IKeyReference
    {
        new string Key { get; set; }

    }
}
