// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Orders
{

    public partial class OrderSetOrderNumberActionQueryBuilderDsl
    {
        public OrderSetOrderNumberActionQueryBuilderDsl()
        {
        }

        public static OrderSetOrderNumberActionQueryBuilderDsl Of()
        {
            return new OrderSetOrderNumberActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<OrderSetOrderNumberActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<OrderSetOrderNumberActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<OrderSetOrderNumberActionQueryBuilderDsl>(p, OrderSetOrderNumberActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<OrderSetOrderNumberActionQueryBuilderDsl, string> OrderNumber()
        {
            return new ComparisonPredicateBuilder<OrderSetOrderNumberActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("orderNumber")),
            p => new CombinationQueryPredicate<OrderSetOrderNumberActionQueryBuilderDsl>(p, OrderSetOrderNumberActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
