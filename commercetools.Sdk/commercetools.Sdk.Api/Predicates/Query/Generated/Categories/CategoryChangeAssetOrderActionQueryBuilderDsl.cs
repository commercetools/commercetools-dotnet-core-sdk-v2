using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Categories
{

    public partial class CategoryChangeAssetOrderActionQueryBuilderDsl
    {
        public CategoryChangeAssetOrderActionQueryBuilderDsl()
        {
        }

        public static CategoryChangeAssetOrderActionQueryBuilderDsl Of()
        {
            return new CategoryChangeAssetOrderActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CategoryChangeAssetOrderActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<CategoryChangeAssetOrderActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<CategoryChangeAssetOrderActionQueryBuilderDsl>(p, CategoryChangeAssetOrderActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparableCollectionPredicateBuilder<CategoryChangeAssetOrderActionQueryBuilderDsl, string> AssetOrder()
        {
            return new ComparableCollectionPredicateBuilder<CategoryChangeAssetOrderActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("assetOrder")),
            p => new CombinationQueryPredicate<CategoryChangeAssetOrderActionQueryBuilderDsl>(p, CategoryChangeAssetOrderActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
