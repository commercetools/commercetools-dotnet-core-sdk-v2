using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ProductDiscounts
{

    public partial class ProductDiscountMatchQueryQueryBuilderDsl
    {
        public ProductDiscountMatchQueryQueryBuilderDsl()
        {
        }

        public static ProductDiscountMatchQueryQueryBuilderDsl Of()
        {
            return new ProductDiscountMatchQueryQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductDiscountMatchQueryQueryBuilderDsl, string> ProductId()
        {
            return new ComparisonPredicateBuilder<ProductDiscountMatchQueryQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("productId")),
            p => new CombinationQueryPredicate<ProductDiscountMatchQueryQueryBuilderDsl>(p, ProductDiscountMatchQueryQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductDiscountMatchQueryQueryBuilderDsl, long> VariantId()
        {
            return new ComparisonPredicateBuilder<ProductDiscountMatchQueryQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("variantId")),
            p => new CombinationQueryPredicate<ProductDiscountMatchQueryQueryBuilderDsl>(p, ProductDiscountMatchQueryQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductDiscountMatchQueryQueryBuilderDsl, bool> Staged()
        {
            return new ComparisonPredicateBuilder<ProductDiscountMatchQueryQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("staged")),
            p => new CombinationQueryPredicate<ProductDiscountMatchQueryQueryBuilderDsl>(p, ProductDiscountMatchQueryQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ProductDiscountMatchQueryQueryBuilderDsl> Price(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.QueryPriceQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.QueryPriceQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductDiscountMatchQueryQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("price"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.QueryPriceQueryBuilderDsl.Of())),
                ProductDiscountMatchQueryQueryBuilderDsl.Of);
        }


    }
}
