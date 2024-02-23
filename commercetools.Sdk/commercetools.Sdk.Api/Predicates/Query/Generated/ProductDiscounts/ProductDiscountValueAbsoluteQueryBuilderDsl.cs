using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ProductDiscounts
{

    public partial class ProductDiscountValueAbsoluteQueryBuilderDsl
    {
        public ProductDiscountValueAbsoluteQueryBuilderDsl()
        {
        }

        public static ProductDiscountValueAbsoluteQueryBuilderDsl Of()
        {
            return new ProductDiscountValueAbsoluteQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductDiscountValueAbsoluteQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<ProductDiscountValueAbsoluteQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<ProductDiscountValueAbsoluteQueryBuilderDsl>(p, ProductDiscountValueAbsoluteQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ProductDiscountValueAbsoluteQueryBuilderDsl> Money(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.CentPrecisionMoneyQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.CentPrecisionMoneyQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductDiscountValueAbsoluteQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("money"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.CentPrecisionMoneyQueryBuilderDsl.Of())),
                ProductDiscountValueAbsoluteQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<ProductDiscountValueAbsoluteQueryBuilderDsl> Money()
        {
            return new CollectionPredicateBuilder<ProductDiscountValueAbsoluteQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("money")),
                    p => new CombinationQueryPredicate<ProductDiscountValueAbsoluteQueryBuilderDsl>(p, ProductDiscountValueAbsoluteQueryBuilderDsl.Of));
        }

    }
}
