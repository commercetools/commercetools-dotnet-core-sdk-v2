// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.RecurringOrders
{

    public partial class RecurringOrderPausedQueryBuilderDsl
    {
        public RecurringOrderPausedQueryBuilderDsl()
        {
        }

        public static RecurringOrderPausedQueryBuilderDsl Of()
        {
            return new RecurringOrderPausedQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<RecurringOrderPausedQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<RecurringOrderPausedQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<RecurringOrderPausedQueryBuilderDsl>(p, RecurringOrderPausedQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
