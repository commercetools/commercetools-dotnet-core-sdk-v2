// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.RecurringOrders
{

    public partial class NonRecurringOrdersOnlyQueryBuilderDsl
    {
        public NonRecurringOrdersOnlyQueryBuilderDsl()
        {
        }

        public static NonRecurringOrdersOnlyQueryBuilderDsl Of()
        {
            return new NonRecurringOrdersOnlyQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<NonRecurringOrdersOnlyQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<NonRecurringOrdersOnlyQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<NonRecurringOrdersOnlyQueryBuilderDsl>(p, NonRecurringOrdersOnlyQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
