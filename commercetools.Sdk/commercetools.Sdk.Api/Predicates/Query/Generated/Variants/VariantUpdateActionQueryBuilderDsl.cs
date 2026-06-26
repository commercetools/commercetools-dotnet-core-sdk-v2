using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Variants
{

    public partial class VariantUpdateActionQueryBuilderDsl
    {
        public VariantUpdateActionQueryBuilderDsl()
        {
        }

        public static VariantUpdateActionQueryBuilderDsl Of()
        {
            return new VariantUpdateActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<VariantUpdateActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<VariantUpdateActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<VariantUpdateActionQueryBuilderDsl>(p, VariantUpdateActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

        public CombinationQueryPredicate<VariantUpdateActionQueryBuilderDsl> AsAddAsset(
            Func<commercetools.Sdk.Api.Predicates.Query.Variants.VariantAddAssetActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Variants.VariantAddAssetActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<VariantUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Variants.VariantAddAssetActionQueryBuilderDsl.Of()),
                VariantUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<VariantUpdateActionQueryBuilderDsl> AsAddExternalImage(
            Func<commercetools.Sdk.Api.Predicates.Query.Variants.VariantAddExternalImageActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Variants.VariantAddExternalImageActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<VariantUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Variants.VariantAddExternalImageActionQueryBuilderDsl.Of()),
                VariantUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<VariantUpdateActionQueryBuilderDsl> AsChangeAssetName(
            Func<commercetools.Sdk.Api.Predicates.Query.Variants.VariantChangeAssetNameActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Variants.VariantChangeAssetNameActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<VariantUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Variants.VariantChangeAssetNameActionQueryBuilderDsl.Of()),
                VariantUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<VariantUpdateActionQueryBuilderDsl> AsChangeAssetOrder(
            Func<commercetools.Sdk.Api.Predicates.Query.Variants.VariantChangeAssetOrderActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Variants.VariantChangeAssetOrderActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<VariantUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Variants.VariantChangeAssetOrderActionQueryBuilderDsl.Of()),
                VariantUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<VariantUpdateActionQueryBuilderDsl> AsPublish(
            Func<commercetools.Sdk.Api.Predicates.Query.Variants.VariantPublishActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Variants.VariantPublishActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<VariantUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Variants.VariantPublishActionQueryBuilderDsl.Of()),
                VariantUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<VariantUpdateActionQueryBuilderDsl> AsRemoveAsset(
            Func<commercetools.Sdk.Api.Predicates.Query.Variants.VariantRemoveAssetActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Variants.VariantRemoveAssetActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<VariantUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Variants.VariantRemoveAssetActionQueryBuilderDsl.Of()),
                VariantUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<VariantUpdateActionQueryBuilderDsl> AsRemoveImage(
            Func<commercetools.Sdk.Api.Predicates.Query.Variants.VariantRemoveImageActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Variants.VariantRemoveImageActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<VariantUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Variants.VariantRemoveImageActionQueryBuilderDsl.Of()),
                VariantUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<VariantUpdateActionQueryBuilderDsl> AsRemoveStagedChanges(
            Func<commercetools.Sdk.Api.Predicates.Query.Variants.VariantRemoveStagedChangesActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Variants.VariantRemoveStagedChangesActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<VariantUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Variants.VariantRemoveStagedChangesActionQueryBuilderDsl.Of()),
                VariantUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<VariantUpdateActionQueryBuilderDsl> AsSetAssetCustomField(
            Func<commercetools.Sdk.Api.Predicates.Query.Variants.VariantSetAssetCustomFieldActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Variants.VariantSetAssetCustomFieldActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<VariantUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Variants.VariantSetAssetCustomFieldActionQueryBuilderDsl.Of()),
                VariantUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<VariantUpdateActionQueryBuilderDsl> AsSetAssetCustomType(
            Func<commercetools.Sdk.Api.Predicates.Query.Variants.VariantSetAssetCustomTypeActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Variants.VariantSetAssetCustomTypeActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<VariantUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Variants.VariantSetAssetCustomTypeActionQueryBuilderDsl.Of()),
                VariantUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<VariantUpdateActionQueryBuilderDsl> AsSetAssetDescription(
            Func<commercetools.Sdk.Api.Predicates.Query.Variants.VariantSetAssetDescriptionActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Variants.VariantSetAssetDescriptionActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<VariantUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Variants.VariantSetAssetDescriptionActionQueryBuilderDsl.Of()),
                VariantUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<VariantUpdateActionQueryBuilderDsl> AsSetAssetKey(
            Func<commercetools.Sdk.Api.Predicates.Query.Variants.VariantSetAssetKeyActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Variants.VariantSetAssetKeyActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<VariantUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Variants.VariantSetAssetKeyActionQueryBuilderDsl.Of()),
                VariantUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<VariantUpdateActionQueryBuilderDsl> AsSetAssetSources(
            Func<commercetools.Sdk.Api.Predicates.Query.Variants.VariantSetAssetSourcesActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Variants.VariantSetAssetSourcesActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<VariantUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Variants.VariantSetAssetSourcesActionQueryBuilderDsl.Of()),
                VariantUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<VariantUpdateActionQueryBuilderDsl> AsSetAssetTags(
            Func<commercetools.Sdk.Api.Predicates.Query.Variants.VariantSetAssetTagsActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Variants.VariantSetAssetTagsActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<VariantUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Variants.VariantSetAssetTagsActionQueryBuilderDsl.Of()),
                VariantUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<VariantUpdateActionQueryBuilderDsl> AsSetAssets(
            Func<commercetools.Sdk.Api.Predicates.Query.Variants.VariantSetAssetsActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Variants.VariantSetAssetsActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<VariantUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Variants.VariantSetAssetsActionQueryBuilderDsl.Of()),
                VariantUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<VariantUpdateActionQueryBuilderDsl> AsSetAttribute(
            Func<commercetools.Sdk.Api.Predicates.Query.Variants.VariantSetAttributeActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Variants.VariantSetAttributeActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<VariantUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Variants.VariantSetAttributeActionQueryBuilderDsl.Of()),
                VariantUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<VariantUpdateActionQueryBuilderDsl> AsSetAttributes(
            Func<commercetools.Sdk.Api.Predicates.Query.Variants.VariantSetAttributesActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Variants.VariantSetAttributesActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<VariantUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Variants.VariantSetAttributesActionQueryBuilderDsl.Of()),
                VariantUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<VariantUpdateActionQueryBuilderDsl> AsSetImages(
            Func<commercetools.Sdk.Api.Predicates.Query.Variants.VariantSetImagesActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Variants.VariantSetImagesActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<VariantUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Variants.VariantSetImagesActionQueryBuilderDsl.Of()),
                VariantUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<VariantUpdateActionQueryBuilderDsl> AsSetKey(
            Func<commercetools.Sdk.Api.Predicates.Query.Variants.VariantSetKeyActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Variants.VariantSetKeyActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<VariantUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Variants.VariantSetKeyActionQueryBuilderDsl.Of()),
                VariantUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<VariantUpdateActionQueryBuilderDsl> AsSetSku(
            Func<commercetools.Sdk.Api.Predicates.Query.Variants.VariantSetSkuActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Variants.VariantSetSkuActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<VariantUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Variants.VariantSetSkuActionQueryBuilderDsl.Of()),
                VariantUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<VariantUpdateActionQueryBuilderDsl> AsUnpublish(
            Func<commercetools.Sdk.Api.Predicates.Query.Variants.VariantUnpublishActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Variants.VariantUnpublishActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<VariantUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Variants.VariantUnpublishActionQueryBuilderDsl.Of()),
                VariantUpdateActionQueryBuilderDsl.Of);
        }
    }
}
