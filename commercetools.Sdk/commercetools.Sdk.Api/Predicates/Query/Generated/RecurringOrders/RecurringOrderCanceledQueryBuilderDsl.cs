// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.RecurringOrders
{

    public partial class RecurringOrderCanceledQueryBuilderDsl
    {
        public RecurringOrderCanceledQueryBuilderDsl()
        {
        }

        public static RecurringOrderCanceledQueryBuilderDsl Of()
        {
            return new RecurringOrderCanceledQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<RecurringOrderCanceledQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<RecurringOrderCanceledQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<RecurringOrderCanceledQueryBuilderDsl>(p, RecurringOrderCanceledQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<RecurringOrderCanceledQueryBuilderDsl, string> Reason()
        {
            return new ComparisonPredicateBuilder<RecurringOrderCanceledQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("reason")),
            p => new CombinationQueryPredicate<RecurringOrderCanceledQueryBuilderDsl>(p, RecurringOrderCanceledQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
