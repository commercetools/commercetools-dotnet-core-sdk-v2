// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ShippingMethods
{

    public partial class ShippingMethodChangeActiveActionQueryBuilderDsl
    {
        public ShippingMethodChangeActiveActionQueryBuilderDsl()
        {
        }

        public static ShippingMethodChangeActiveActionQueryBuilderDsl Of()
        {
            return new ShippingMethodChangeActiveActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ShippingMethodChangeActiveActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<ShippingMethodChangeActiveActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<ShippingMethodChangeActiveActionQueryBuilderDsl>(p, ShippingMethodChangeActiveActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ShippingMethodChangeActiveActionQueryBuilderDsl, bool> Active()
        {
            return new ComparisonPredicateBuilder<ShippingMethodChangeActiveActionQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("active")),
            p => new CombinationQueryPredicate<ShippingMethodChangeActiveActionQueryBuilderDsl>(p, ShippingMethodChangeActiveActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
