using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Products;
using System;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Variants
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Variants.Variant))]
    public partial interface IVariant : IBaseResource
    {
        new string Id { get; set; }

        new long Version { get; set; }

        new DateTime CreatedAt { get; set; }

        new DateTime LastModifiedAt { get; set; }

        ILastModifiedBy LastModifiedBy { get; set; }

        ICreatedBy CreatedBy { get; set; }

        string Key { get; set; }

        int VariantId { get; set; }

        IProductReference Product { get; set; }

        bool Published { get; set; }

        IVariantData Current { get; set; }

        IVariantData Staged { get; set; }

    }
}
