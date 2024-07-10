using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Categories
{

    public partial class CategorySetAssetCustomFieldActionQueryBuilderDsl
    {
        public CategorySetAssetCustomFieldActionQueryBuilderDsl()
        {
        }

        public static CategorySetAssetCustomFieldActionQueryBuilderDsl Of()
        {
            return new CategorySetAssetCustomFieldActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CategorySetAssetCustomFieldActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<CategorySetAssetCustomFieldActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<CategorySetAssetCustomFieldActionQueryBuilderDsl>(p, CategorySetAssetCustomFieldActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CategorySetAssetCustomFieldActionQueryBuilderDsl, string> AssetId()
        {
            return new ComparisonPredicateBuilder<CategorySetAssetCustomFieldActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("assetId")),
            p => new CombinationQueryPredicate<CategorySetAssetCustomFieldActionQueryBuilderDsl>(p, CategorySetAssetCustomFieldActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CategorySetAssetCustomFieldActionQueryBuilderDsl, string> AssetKey()
        {
            return new ComparisonPredicateBuilder<CategorySetAssetCustomFieldActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("assetKey")),
            p => new CombinationQueryPredicate<CategorySetAssetCustomFieldActionQueryBuilderDsl>(p, CategorySetAssetCustomFieldActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CategorySetAssetCustomFieldActionQueryBuilderDsl, string> Name()
        {
            return new ComparisonPredicateBuilder<CategorySetAssetCustomFieldActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("name")),
            p => new CombinationQueryPredicate<CategorySetAssetCustomFieldActionQueryBuilderDsl>(p, CategorySetAssetCustomFieldActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CategorySetAssetCustomFieldActionQueryBuilderDsl, string> Value()
        {
            return new ComparisonPredicateBuilder<CategorySetAssetCustomFieldActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("value")),
            p => new CombinationQueryPredicate<CategorySetAssetCustomFieldActionQueryBuilderDsl>(p, CategorySetAssetCustomFieldActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
