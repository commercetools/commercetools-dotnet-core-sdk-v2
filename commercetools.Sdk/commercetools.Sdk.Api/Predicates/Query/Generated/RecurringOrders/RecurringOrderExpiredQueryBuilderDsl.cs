// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.RecurringOrders
{

    public partial class RecurringOrderExpiredQueryBuilderDsl
    {
        public RecurringOrderExpiredQueryBuilderDsl()
        {
        }

        public static RecurringOrderExpiredQueryBuilderDsl Of()
        {
            return new RecurringOrderExpiredQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<RecurringOrderExpiredQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<RecurringOrderExpiredQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<RecurringOrderExpiredQueryBuilderDsl>(p, RecurringOrderExpiredQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
