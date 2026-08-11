using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Variants
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Variants.VariantSetKeyAction))]
    public partial interface IVariantSetKeyAction : IVariantUpdateAction
    {
        string Key { get; set; }

    }
}
