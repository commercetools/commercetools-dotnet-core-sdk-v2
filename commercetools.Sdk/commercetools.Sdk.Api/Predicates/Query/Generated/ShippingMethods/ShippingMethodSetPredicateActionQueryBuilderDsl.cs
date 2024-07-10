using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ShippingMethods
{

    public partial class ShippingMethodSetPredicateActionQueryBuilderDsl
    {
        public ShippingMethodSetPredicateActionQueryBuilderDsl()
        {
        }

        public static ShippingMethodSetPredicateActionQueryBuilderDsl Of()
        {
            return new ShippingMethodSetPredicateActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ShippingMethodSetPredicateActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<ShippingMethodSetPredicateActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<ShippingMethodSetPredicateActionQueryBuilderDsl>(p, ShippingMethodSetPredicateActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ShippingMethodSetPredicateActionQueryBuilderDsl, string> Predicate()
        {
            return new ComparisonPredicateBuilder<ShippingMethodSetPredicateActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("predicate")),
            p => new CombinationQueryPredicate<ShippingMethodSetPredicateActionQueryBuilderDsl>(p, ShippingMethodSetPredicateActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
