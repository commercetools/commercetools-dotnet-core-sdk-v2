using System;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ProductSelections
{
    [TypeDiscriminator(nameof(Type))]
    [DefaultTypeDiscriminator(typeof(commercetools.Sdk.Api.Models.ProductSelections.ProductVariantSelection))]
    [SubTypeDiscriminator("exclusion", typeof(commercetools.Sdk.Api.Models.ProductSelections.ProductVariantSelectionExclusion))]
    [SubTypeDiscriminator("includeAllExcept", typeof(commercetools.Sdk.Api.Models.ProductSelections.ProductVariantSelectionIncludeAllExcept))]
    [SubTypeDiscriminator("includeOnly", typeof(commercetools.Sdk.Api.Models.ProductSelections.ProductVariantSelectionIncludeOnly))]
    [SubTypeDiscriminator("inclusion", typeof(commercetools.Sdk.Api.Models.ProductSelections.ProductVariantSelectionInclusion))]
    public partial interface IProductVariantSelection
    {
        IProductVariantSelectionTypeEnum Type { get; set; }

        static commercetools.Sdk.Api.Models.ProductSelections.ProductVariantSelectionExclusion Exclusion(Action<commercetools.Sdk.Api.Models.ProductSelections.ProductVariantSelectionExclusion> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.ProductSelections.ProductVariantSelectionExclusion();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.ProductSelections.ProductVariantSelectionIncludeAllExcept IncludeAllExcept(Action<commercetools.Sdk.Api.Models.ProductSelections.ProductVariantSelectionIncludeAllExcept> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.ProductSelections.ProductVariantSelectionIncludeAllExcept();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.ProductSelections.ProductVariantSelectionIncludeOnly IncludeOnly(Action<commercetools.Sdk.Api.Models.ProductSelections.ProductVariantSelectionIncludeOnly> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.ProductSelections.ProductVariantSelectionIncludeOnly();
            init?.Invoke(t);
            return t;
        }
        static commercetools.Sdk.Api.Models.ProductSelections.ProductVariantSelectionInclusion Inclusion(Action<commercetools.Sdk.Api.Models.ProductSelections.ProductVariantSelectionInclusion> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.ProductSelections.ProductVariantSelectionInclusion();
            init?.Invoke(t);
            return t;
        }
    }
}
