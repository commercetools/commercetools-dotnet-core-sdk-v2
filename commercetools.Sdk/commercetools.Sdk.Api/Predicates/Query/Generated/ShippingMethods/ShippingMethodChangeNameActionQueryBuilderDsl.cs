using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ShippingMethods
{

    public partial class ShippingMethodChangeNameActionQueryBuilderDsl
    {
        public ShippingMethodChangeNameActionQueryBuilderDsl()
        {
        }

        public static ShippingMethodChangeNameActionQueryBuilderDsl Of()
        {
            return new ShippingMethodChangeNameActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ShippingMethodChangeNameActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<ShippingMethodChangeNameActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<ShippingMethodChangeNameActionQueryBuilderDsl>(p, ShippingMethodChangeNameActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ShippingMethodChangeNameActionQueryBuilderDsl, string> Name()
        {
            return new ComparisonPredicateBuilder<ShippingMethodChangeNameActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("name")),
            p => new CombinationQueryPredicate<ShippingMethodChangeNameActionQueryBuilderDsl>(p, ShippingMethodChangeNameActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
