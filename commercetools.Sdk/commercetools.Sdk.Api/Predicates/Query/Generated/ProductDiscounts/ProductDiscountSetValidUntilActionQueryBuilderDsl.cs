using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ProductDiscounts
{

    public partial class ProductDiscountSetValidUntilActionQueryBuilderDsl
    {
        public ProductDiscountSetValidUntilActionQueryBuilderDsl()
        {
        }

        public static ProductDiscountSetValidUntilActionQueryBuilderDsl Of()
        {
            return new ProductDiscountSetValidUntilActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductDiscountSetValidUntilActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<ProductDiscountSetValidUntilActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<ProductDiscountSetValidUntilActionQueryBuilderDsl>(p, ProductDiscountSetValidUntilActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductDiscountSetValidUntilActionQueryBuilderDsl, DateTime> ValidUntil()
        {
            return new ComparisonPredicateBuilder<ProductDiscountSetValidUntilActionQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("validUntil")),
            p => new CombinationQueryPredicate<ProductDiscountSetValidUntilActionQueryBuilderDsl>(p, ProductDiscountSetValidUntilActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
