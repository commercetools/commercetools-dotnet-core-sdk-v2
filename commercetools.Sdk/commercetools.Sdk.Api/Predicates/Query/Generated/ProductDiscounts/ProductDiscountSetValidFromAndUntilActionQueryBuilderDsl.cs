using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ProductDiscounts
{

    public partial class ProductDiscountSetValidFromAndUntilActionQueryBuilderDsl
    {
        public ProductDiscountSetValidFromAndUntilActionQueryBuilderDsl()
        {
        }

        public static ProductDiscountSetValidFromAndUntilActionQueryBuilderDsl Of()
        {
            return new ProductDiscountSetValidFromAndUntilActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductDiscountSetValidFromAndUntilActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<ProductDiscountSetValidFromAndUntilActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<ProductDiscountSetValidFromAndUntilActionQueryBuilderDsl>(p, ProductDiscountSetValidFromAndUntilActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductDiscountSetValidFromAndUntilActionQueryBuilderDsl, DateTime> ValidFrom()
        {
            return new ComparisonPredicateBuilder<ProductDiscountSetValidFromAndUntilActionQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("validFrom")),
            p => new CombinationQueryPredicate<ProductDiscountSetValidFromAndUntilActionQueryBuilderDsl>(p, ProductDiscountSetValidFromAndUntilActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductDiscountSetValidFromAndUntilActionQueryBuilderDsl, DateTime> ValidUntil()
        {
            return new ComparisonPredicateBuilder<ProductDiscountSetValidFromAndUntilActionQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("validUntil")),
            p => new CombinationQueryPredicate<ProductDiscountSetValidFromAndUntilActionQueryBuilderDsl>(p, ProductDiscountSetValidFromAndUntilActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
