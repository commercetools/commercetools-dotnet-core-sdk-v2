using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.DiscountCodes
{

    public partial class DiscountCodeChangeIsActiveActionQueryBuilderDsl
    {
        public DiscountCodeChangeIsActiveActionQueryBuilderDsl()
        {
        }

        public static DiscountCodeChangeIsActiveActionQueryBuilderDsl Of()
        {
            return new DiscountCodeChangeIsActiveActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<DiscountCodeChangeIsActiveActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<DiscountCodeChangeIsActiveActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<DiscountCodeChangeIsActiveActionQueryBuilderDsl>(p, DiscountCodeChangeIsActiveActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<DiscountCodeChangeIsActiveActionQueryBuilderDsl, bool> IsActive()
        {
            return new ComparisonPredicateBuilder<DiscountCodeChangeIsActiveActionQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("isActive")),
            p => new CombinationQueryPredicate<DiscountCodeChangeIsActiveActionQueryBuilderDsl>(p, DiscountCodeChangeIsActiveActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
