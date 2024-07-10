using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Categories
{

    public partial class CategorySetAssetTagsActionQueryBuilderDsl
    {
        public CategorySetAssetTagsActionQueryBuilderDsl()
        {
        }

        public static CategorySetAssetTagsActionQueryBuilderDsl Of()
        {
            return new CategorySetAssetTagsActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CategorySetAssetTagsActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<CategorySetAssetTagsActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<CategorySetAssetTagsActionQueryBuilderDsl>(p, CategorySetAssetTagsActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CategorySetAssetTagsActionQueryBuilderDsl, string> AssetId()
        {
            return new ComparisonPredicateBuilder<CategorySetAssetTagsActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("assetId")),
            p => new CombinationQueryPredicate<CategorySetAssetTagsActionQueryBuilderDsl>(p, CategorySetAssetTagsActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CategorySetAssetTagsActionQueryBuilderDsl, string> AssetKey()
        {
            return new ComparisonPredicateBuilder<CategorySetAssetTagsActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("assetKey")),
            p => new CombinationQueryPredicate<CategorySetAssetTagsActionQueryBuilderDsl>(p, CategorySetAssetTagsActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparableCollectionPredicateBuilder<CategorySetAssetTagsActionQueryBuilderDsl, string> Tags()
        {
            return new ComparableCollectionPredicateBuilder<CategorySetAssetTagsActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("tags")),
            p => new CombinationQueryPredicate<CategorySetAssetTagsActionQueryBuilderDsl>(p, CategorySetAssetTagsActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
