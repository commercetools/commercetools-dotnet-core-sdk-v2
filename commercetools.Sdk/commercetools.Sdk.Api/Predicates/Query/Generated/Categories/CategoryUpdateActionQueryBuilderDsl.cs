using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Categories
{

    public partial class CategoryUpdateActionQueryBuilderDsl
    {
        public CategoryUpdateActionQueryBuilderDsl()
        {
        }

        public static CategoryUpdateActionQueryBuilderDsl Of()
        {
            return new CategoryUpdateActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CategoryUpdateActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<CategoryUpdateActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<CategoryUpdateActionQueryBuilderDsl>(p, CategoryUpdateActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

        public CombinationQueryPredicate<CategoryUpdateActionQueryBuilderDsl> AsAddAsset(
            Func<commercetools.Sdk.Api.Predicates.Query.Categories.CategoryAddAssetActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Categories.CategoryAddAssetActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CategoryUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Categories.CategoryAddAssetActionQueryBuilderDsl.Of()),
                CategoryUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<CategoryUpdateActionQueryBuilderDsl> AsChangeAssetName(
            Func<commercetools.Sdk.Api.Predicates.Query.Categories.CategoryChangeAssetNameActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Categories.CategoryChangeAssetNameActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CategoryUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Categories.CategoryChangeAssetNameActionQueryBuilderDsl.Of()),
                CategoryUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<CategoryUpdateActionQueryBuilderDsl> AsChangeAssetOrder(
            Func<commercetools.Sdk.Api.Predicates.Query.Categories.CategoryChangeAssetOrderActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Categories.CategoryChangeAssetOrderActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CategoryUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Categories.CategoryChangeAssetOrderActionQueryBuilderDsl.Of()),
                CategoryUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<CategoryUpdateActionQueryBuilderDsl> AsChangeName(
            Func<commercetools.Sdk.Api.Predicates.Query.Categories.CategoryChangeNameActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Categories.CategoryChangeNameActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CategoryUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Categories.CategoryChangeNameActionQueryBuilderDsl.Of()),
                CategoryUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<CategoryUpdateActionQueryBuilderDsl> AsChangeOrderHint(
            Func<commercetools.Sdk.Api.Predicates.Query.Categories.CategoryChangeOrderHintActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Categories.CategoryChangeOrderHintActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CategoryUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Categories.CategoryChangeOrderHintActionQueryBuilderDsl.Of()),
                CategoryUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<CategoryUpdateActionQueryBuilderDsl> AsChangeParent(
            Func<commercetools.Sdk.Api.Predicates.Query.Categories.CategoryChangeParentActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Categories.CategoryChangeParentActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CategoryUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Categories.CategoryChangeParentActionQueryBuilderDsl.Of()),
                CategoryUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<CategoryUpdateActionQueryBuilderDsl> AsChangeSlug(
            Func<commercetools.Sdk.Api.Predicates.Query.Categories.CategoryChangeSlugActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Categories.CategoryChangeSlugActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CategoryUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Categories.CategoryChangeSlugActionQueryBuilderDsl.Of()),
                CategoryUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<CategoryUpdateActionQueryBuilderDsl> AsRemoveAsset(
            Func<commercetools.Sdk.Api.Predicates.Query.Categories.CategoryRemoveAssetActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Categories.CategoryRemoveAssetActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CategoryUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Categories.CategoryRemoveAssetActionQueryBuilderDsl.Of()),
                CategoryUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<CategoryUpdateActionQueryBuilderDsl> AsSetAssetCustomField(
            Func<commercetools.Sdk.Api.Predicates.Query.Categories.CategorySetAssetCustomFieldActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Categories.CategorySetAssetCustomFieldActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CategoryUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Categories.CategorySetAssetCustomFieldActionQueryBuilderDsl.Of()),
                CategoryUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<CategoryUpdateActionQueryBuilderDsl> AsSetAssetCustomType(
            Func<commercetools.Sdk.Api.Predicates.Query.Categories.CategorySetAssetCustomTypeActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Categories.CategorySetAssetCustomTypeActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CategoryUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Categories.CategorySetAssetCustomTypeActionQueryBuilderDsl.Of()),
                CategoryUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<CategoryUpdateActionQueryBuilderDsl> AsSetAssetDescription(
            Func<commercetools.Sdk.Api.Predicates.Query.Categories.CategorySetAssetDescriptionActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Categories.CategorySetAssetDescriptionActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CategoryUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Categories.CategorySetAssetDescriptionActionQueryBuilderDsl.Of()),
                CategoryUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<CategoryUpdateActionQueryBuilderDsl> AsSetAssetKey(
            Func<commercetools.Sdk.Api.Predicates.Query.Categories.CategorySetAssetKeyActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Categories.CategorySetAssetKeyActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CategoryUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Categories.CategorySetAssetKeyActionQueryBuilderDsl.Of()),
                CategoryUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<CategoryUpdateActionQueryBuilderDsl> AsSetAssetSources(
            Func<commercetools.Sdk.Api.Predicates.Query.Categories.CategorySetAssetSourcesActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Categories.CategorySetAssetSourcesActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CategoryUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Categories.CategorySetAssetSourcesActionQueryBuilderDsl.Of()),
                CategoryUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<CategoryUpdateActionQueryBuilderDsl> AsSetAssetTags(
            Func<commercetools.Sdk.Api.Predicates.Query.Categories.CategorySetAssetTagsActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Categories.CategorySetAssetTagsActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CategoryUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Categories.CategorySetAssetTagsActionQueryBuilderDsl.Of()),
                CategoryUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<CategoryUpdateActionQueryBuilderDsl> AsSetCustomField(
            Func<commercetools.Sdk.Api.Predicates.Query.Categories.CategorySetCustomFieldActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Categories.CategorySetCustomFieldActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CategoryUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Categories.CategorySetCustomFieldActionQueryBuilderDsl.Of()),
                CategoryUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<CategoryUpdateActionQueryBuilderDsl> AsSetCustomType(
            Func<commercetools.Sdk.Api.Predicates.Query.Categories.CategorySetCustomTypeActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Categories.CategorySetCustomTypeActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CategoryUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Categories.CategorySetCustomTypeActionQueryBuilderDsl.Of()),
                CategoryUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<CategoryUpdateActionQueryBuilderDsl> AsSetDescription(
            Func<commercetools.Sdk.Api.Predicates.Query.Categories.CategorySetDescriptionActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Categories.CategorySetDescriptionActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CategoryUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Categories.CategorySetDescriptionActionQueryBuilderDsl.Of()),
                CategoryUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<CategoryUpdateActionQueryBuilderDsl> AsSetExternalId(
            Func<commercetools.Sdk.Api.Predicates.Query.Categories.CategorySetExternalIdActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Categories.CategorySetExternalIdActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CategoryUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Categories.CategorySetExternalIdActionQueryBuilderDsl.Of()),
                CategoryUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<CategoryUpdateActionQueryBuilderDsl> AsSetKey(
            Func<commercetools.Sdk.Api.Predicates.Query.Categories.CategorySetKeyActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Categories.CategorySetKeyActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CategoryUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Categories.CategorySetKeyActionQueryBuilderDsl.Of()),
                CategoryUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<CategoryUpdateActionQueryBuilderDsl> AsSetMetaDescription(
            Func<commercetools.Sdk.Api.Predicates.Query.Categories.CategorySetMetaDescriptionActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Categories.CategorySetMetaDescriptionActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CategoryUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Categories.CategorySetMetaDescriptionActionQueryBuilderDsl.Of()),
                CategoryUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<CategoryUpdateActionQueryBuilderDsl> AsSetMetaKeywords(
            Func<commercetools.Sdk.Api.Predicates.Query.Categories.CategorySetMetaKeywordsActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Categories.CategorySetMetaKeywordsActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CategoryUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Categories.CategorySetMetaKeywordsActionQueryBuilderDsl.Of()),
                CategoryUpdateActionQueryBuilderDsl.Of);
        }
        public CombinationQueryPredicate<CategoryUpdateActionQueryBuilderDsl> AsSetMetaTitle(
            Func<commercetools.Sdk.Api.Predicates.Query.Categories.CategorySetMetaTitleActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Categories.CategorySetMetaTitleActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CategoryUpdateActionQueryBuilderDsl>(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Categories.CategorySetMetaTitleActionQueryBuilderDsl.Of()),
                CategoryUpdateActionQueryBuilderDsl.Of);
        }
    }
}
