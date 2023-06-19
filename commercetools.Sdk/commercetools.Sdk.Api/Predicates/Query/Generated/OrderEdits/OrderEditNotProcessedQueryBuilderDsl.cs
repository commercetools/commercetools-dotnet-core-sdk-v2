// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.OrderEdits
{

    public partial class OrderEditNotProcessedQueryBuilderDsl
    {
        public OrderEditNotProcessedQueryBuilderDsl()
        {
        }

        public static OrderEditNotProcessedQueryBuilderDsl Of()
        {
            return new OrderEditNotProcessedQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<OrderEditNotProcessedQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<OrderEditNotProcessedQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<OrderEditNotProcessedQueryBuilderDsl>(p, OrderEditNotProcessedQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
