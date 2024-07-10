using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Categories
{

    public partial class CategoryAddAssetActionQueryBuilderDsl
    {
        public CategoryAddAssetActionQueryBuilderDsl()
        {
        }

        public static CategoryAddAssetActionQueryBuilderDsl Of()
        {
            return new CategoryAddAssetActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CategoryAddAssetActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<CategoryAddAssetActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<CategoryAddAssetActionQueryBuilderDsl>(p, CategoryAddAssetActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<CategoryAddAssetActionQueryBuilderDsl> Asset(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.AssetDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.AssetDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<CategoryAddAssetActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("asset"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.AssetDraftQueryBuilderDsl.Of())),
                CategoryAddAssetActionQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<CategoryAddAssetActionQueryBuilderDsl, long> Position()
        {
            return new ComparisonPredicateBuilder<CategoryAddAssetActionQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("position")),
            p => new CombinationQueryPredicate<CategoryAddAssetActionQueryBuilderDsl>(p, CategoryAddAssetActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
