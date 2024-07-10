using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ShippingMethods
{

    public partial class ShippingMethodSetKeyActionQueryBuilderDsl
    {
        public ShippingMethodSetKeyActionQueryBuilderDsl()
        {
        }

        public static ShippingMethodSetKeyActionQueryBuilderDsl Of()
        {
            return new ShippingMethodSetKeyActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ShippingMethodSetKeyActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<ShippingMethodSetKeyActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<ShippingMethodSetKeyActionQueryBuilderDsl>(p, ShippingMethodSetKeyActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ShippingMethodSetKeyActionQueryBuilderDsl, string> Key()
        {
            return new ComparisonPredicateBuilder<ShippingMethodSetKeyActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("key")),
            p => new CombinationQueryPredicate<ShippingMethodSetKeyActionQueryBuilderDsl>(p, ShippingMethodSetKeyActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
