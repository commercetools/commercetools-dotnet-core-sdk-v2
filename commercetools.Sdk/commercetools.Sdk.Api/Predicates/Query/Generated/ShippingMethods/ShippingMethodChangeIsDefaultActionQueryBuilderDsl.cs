// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ShippingMethods
{

    public partial class ShippingMethodChangeIsDefaultActionQueryBuilderDsl
    {
        public ShippingMethodChangeIsDefaultActionQueryBuilderDsl()
        {
        }

        public static ShippingMethodChangeIsDefaultActionQueryBuilderDsl Of()
        {
            return new ShippingMethodChangeIsDefaultActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ShippingMethodChangeIsDefaultActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<ShippingMethodChangeIsDefaultActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<ShippingMethodChangeIsDefaultActionQueryBuilderDsl>(p, ShippingMethodChangeIsDefaultActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ShippingMethodChangeIsDefaultActionQueryBuilderDsl, bool> IsDefault()
        {
            return new ComparisonPredicateBuilder<ShippingMethodChangeIsDefaultActionQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("isDefault")),
            p => new CombinationQueryPredicate<ShippingMethodChangeIsDefaultActionQueryBuilderDsl>(p, ShippingMethodChangeIsDefaultActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
