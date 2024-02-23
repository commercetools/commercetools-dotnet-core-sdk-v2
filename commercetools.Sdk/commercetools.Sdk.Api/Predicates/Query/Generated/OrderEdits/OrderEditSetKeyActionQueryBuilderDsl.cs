// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.OrderEdits
{

    public partial class OrderEditSetKeyActionQueryBuilderDsl
    {
        public OrderEditSetKeyActionQueryBuilderDsl()
        {
        }

        public static OrderEditSetKeyActionQueryBuilderDsl Of()
        {
            return new OrderEditSetKeyActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<OrderEditSetKeyActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<OrderEditSetKeyActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<OrderEditSetKeyActionQueryBuilderDsl>(p, OrderEditSetKeyActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderEditSetKeyActionQueryBuilderDsl, string> Key()
        {
            return new ComparisonPredicateBuilder<OrderEditSetKeyActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("key")),
            p => new CombinationQueryPredicate<OrderEditSetKeyActionQueryBuilderDsl>(p, OrderEditSetKeyActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
