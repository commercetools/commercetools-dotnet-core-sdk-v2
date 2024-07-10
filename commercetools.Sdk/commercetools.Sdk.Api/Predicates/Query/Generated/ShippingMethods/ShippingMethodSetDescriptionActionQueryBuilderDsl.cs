using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ShippingMethods
{

    [Obsolete]
    public partial class ShippingMethodSetDescriptionActionQueryBuilderDsl
    {
        public ShippingMethodSetDescriptionActionQueryBuilderDsl()
        {
        }

        public static ShippingMethodSetDescriptionActionQueryBuilderDsl Of()
        {
            return new ShippingMethodSetDescriptionActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ShippingMethodSetDescriptionActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<ShippingMethodSetDescriptionActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<ShippingMethodSetDescriptionActionQueryBuilderDsl>(p, ShippingMethodSetDescriptionActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ShippingMethodSetDescriptionActionQueryBuilderDsl, string> Description()
        {
            return new ComparisonPredicateBuilder<ShippingMethodSetDescriptionActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("description")),
            p => new CombinationQueryPredicate<ShippingMethodSetDescriptionActionQueryBuilderDsl>(p, ShippingMethodSetDescriptionActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
