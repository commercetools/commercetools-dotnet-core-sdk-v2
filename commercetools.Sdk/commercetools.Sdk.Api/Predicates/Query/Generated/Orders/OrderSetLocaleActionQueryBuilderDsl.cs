// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Orders
{

    public partial class OrderSetLocaleActionQueryBuilderDsl
    {
        public OrderSetLocaleActionQueryBuilderDsl()
        {
        }

        public static OrderSetLocaleActionQueryBuilderDsl Of()
        {
            return new OrderSetLocaleActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<OrderSetLocaleActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<OrderSetLocaleActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<OrderSetLocaleActionQueryBuilderDsl>(p, OrderSetLocaleActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderSetLocaleActionQueryBuilderDsl, string> Locale()
        {
            return new ComparisonPredicateBuilder<OrderSetLocaleActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("locale")),
            p => new CombinationQueryPredicate<OrderSetLocaleActionQueryBuilderDsl>(p, OrderSetLocaleActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
