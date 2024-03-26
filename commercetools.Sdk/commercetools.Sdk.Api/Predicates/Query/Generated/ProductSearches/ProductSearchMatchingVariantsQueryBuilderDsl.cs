using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ProductSearches
{

    public partial class ProductSearchMatchingVariantsQueryBuilderDsl
    {
        public ProductSearchMatchingVariantsQueryBuilderDsl()
        {
        }

        public static ProductSearchMatchingVariantsQueryBuilderDsl Of()
        {
            return new ProductSearchMatchingVariantsQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductSearchMatchingVariantsQueryBuilderDsl, bool> AllMatched()
        {
            return new ComparisonPredicateBuilder<ProductSearchMatchingVariantsQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("allMatched")),
            p => new CombinationQueryPredicate<ProductSearchMatchingVariantsQueryBuilderDsl>(p, ProductSearchMatchingVariantsQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ProductSearchMatchingVariantsQueryBuilderDsl> MatchedVariants(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductSearches.ProductSearchMatchingVariantEntryQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductSearches.ProductSearchMatchingVariantEntryQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductSearchMatchingVariantsQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("matchedVariants"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductSearches.ProductSearchMatchingVariantEntryQueryBuilderDsl.Of())),
                ProductSearchMatchingVariantsQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<ProductSearchMatchingVariantsQueryBuilderDsl> MatchedVariants()
        {
            return new CollectionPredicateBuilder<ProductSearchMatchingVariantsQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("matchedVariants")),
                    p => new CombinationQueryPredicate<ProductSearchMatchingVariantsQueryBuilderDsl>(p, ProductSearchMatchingVariantsQueryBuilderDsl.Of));
        }

    }
}
