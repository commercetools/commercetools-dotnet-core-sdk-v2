using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Variants
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Variants.VariantResourceIdentifier))]
    public partial interface IVariantResourceIdentifier : IResourceIdentifier
    {
        new IReferenceTypeId TypeId { get; set; }

        new string Id { get; set; }

        new string Key { get; set; }

    }
}
