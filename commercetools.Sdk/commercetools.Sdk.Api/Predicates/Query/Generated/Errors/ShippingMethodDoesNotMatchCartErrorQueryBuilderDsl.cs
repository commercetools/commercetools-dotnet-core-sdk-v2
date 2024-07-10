// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Errors
{

    public partial class ShippingMethodDoesNotMatchCartErrorQueryBuilderDsl
    {
        public ShippingMethodDoesNotMatchCartErrorQueryBuilderDsl()
        {
        }

        public static ShippingMethodDoesNotMatchCartErrorQueryBuilderDsl Of()
        {
            return new ShippingMethodDoesNotMatchCartErrorQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ShippingMethodDoesNotMatchCartErrorQueryBuilderDsl, string> Code()
        {
            return new ComparisonPredicateBuilder<ShippingMethodDoesNotMatchCartErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("code")),
            p => new CombinationQueryPredicate<ShippingMethodDoesNotMatchCartErrorQueryBuilderDsl>(p, ShippingMethodDoesNotMatchCartErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ShippingMethodDoesNotMatchCartErrorQueryBuilderDsl, string> Message()
        {
            return new ComparisonPredicateBuilder<ShippingMethodDoesNotMatchCartErrorQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("message")),
            p => new CombinationQueryPredicate<ShippingMethodDoesNotMatchCartErrorQueryBuilderDsl>(p, ShippingMethodDoesNotMatchCartErrorQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
