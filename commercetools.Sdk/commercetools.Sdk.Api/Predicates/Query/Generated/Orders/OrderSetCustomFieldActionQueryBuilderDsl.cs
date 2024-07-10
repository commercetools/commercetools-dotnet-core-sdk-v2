// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Orders
{

    public partial class OrderSetCustomFieldActionQueryBuilderDsl
    {
        public OrderSetCustomFieldActionQueryBuilderDsl()
        {
        }

        public static OrderSetCustomFieldActionQueryBuilderDsl Of()
        {
            return new OrderSetCustomFieldActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<OrderSetCustomFieldActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<OrderSetCustomFieldActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<OrderSetCustomFieldActionQueryBuilderDsl>(p, OrderSetCustomFieldActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderSetCustomFieldActionQueryBuilderDsl, string> Name()
        {
            return new ComparisonPredicateBuilder<OrderSetCustomFieldActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("name")),
            p => new CombinationQueryPredicate<OrderSetCustomFieldActionQueryBuilderDsl>(p, OrderSetCustomFieldActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderSetCustomFieldActionQueryBuilderDsl, string> Value()
        {
            return new ComparisonPredicateBuilder<OrderSetCustomFieldActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("value")),
            p => new CombinationQueryPredicate<OrderSetCustomFieldActionQueryBuilderDsl>(p, OrderSetCustomFieldActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
