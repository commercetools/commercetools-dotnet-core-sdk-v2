// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.RecurringOrders
{

    public partial class RecurringOrdersOnlyQueryBuilderDsl
    {
        public RecurringOrdersOnlyQueryBuilderDsl()
        {
        }

        public static RecurringOrdersOnlyQueryBuilderDsl Of()
        {
            return new RecurringOrdersOnlyQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<RecurringOrdersOnlyQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<RecurringOrdersOnlyQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<RecurringOrdersOnlyQueryBuilderDsl>(p, RecurringOrdersOnlyQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
