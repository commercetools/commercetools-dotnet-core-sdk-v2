using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ProductDiscounts
{

    public partial class ProductDiscountSetValidFromActionQueryBuilderDsl
    {
        public ProductDiscountSetValidFromActionQueryBuilderDsl()
        {
        }

        public static ProductDiscountSetValidFromActionQueryBuilderDsl Of()
        {
            return new ProductDiscountSetValidFromActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductDiscountSetValidFromActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<ProductDiscountSetValidFromActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<ProductDiscountSetValidFromActionQueryBuilderDsl>(p, ProductDiscountSetValidFromActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductDiscountSetValidFromActionQueryBuilderDsl, DateTime> ValidFrom()
        {
            return new ComparisonPredicateBuilder<ProductDiscountSetValidFromActionQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("validFrom")),
            p => new CombinationQueryPredicate<ProductDiscountSetValidFromActionQueryBuilderDsl>(p, ProductDiscountSetValidFromActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
