using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ProductDiscounts
{

    public partial class ProductDiscountUpdateQueryBuilderDsl
    {
        public ProductDiscountUpdateQueryBuilderDsl()
        {
        }

        public static ProductDiscountUpdateQueryBuilderDsl Of()
        {
            return new ProductDiscountUpdateQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductDiscountUpdateQueryBuilderDsl, long> Version()
        {
            return new ComparisonPredicateBuilder<ProductDiscountUpdateQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("version")),
            p => new CombinationQueryPredicate<ProductDiscountUpdateQueryBuilderDsl>(p, ProductDiscountUpdateQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ProductDiscountUpdateQueryBuilderDsl> Actions(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductDiscounts.ProductDiscountUpdateActionQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductDiscounts.ProductDiscountUpdateActionQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductDiscountUpdateQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("actions"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductDiscounts.ProductDiscountUpdateActionQueryBuilderDsl.Of())),
                ProductDiscountUpdateQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<ProductDiscountUpdateQueryBuilderDsl> Actions()
        {
            return new CollectionPredicateBuilder<ProductDiscountUpdateQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("actions")),
                    p => new CombinationQueryPredicate<ProductDiscountUpdateQueryBuilderDsl>(p, ProductDiscountUpdateQueryBuilderDsl.Of));
        }

    }
}
