// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ShippingMethods
{

    public partial class ShippingMethodSetCarrierActionQueryBuilderDsl
    {
        public ShippingMethodSetCarrierActionQueryBuilderDsl()
        {
        }

        public static ShippingMethodSetCarrierActionQueryBuilderDsl Of()
        {
            return new ShippingMethodSetCarrierActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ShippingMethodSetCarrierActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<ShippingMethodSetCarrierActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<ShippingMethodSetCarrierActionQueryBuilderDsl>(p, ShippingMethodSetCarrierActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ShippingMethodSetCarrierActionQueryBuilderDsl, string> Carrier()
        {
            return new ComparisonPredicateBuilder<ShippingMethodSetCarrierActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("carrier")),
            p => new CombinationQueryPredicate<ShippingMethodSetCarrierActionQueryBuilderDsl>(p, ShippingMethodSetCarrierActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
