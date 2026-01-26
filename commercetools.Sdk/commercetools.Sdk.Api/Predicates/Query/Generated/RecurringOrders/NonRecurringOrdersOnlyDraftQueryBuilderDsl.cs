// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.RecurringOrders
{

    public partial class NonRecurringOrdersOnlyDraftQueryBuilderDsl
    {
        public NonRecurringOrdersOnlyDraftQueryBuilderDsl()
        {
        }

        public static NonRecurringOrdersOnlyDraftQueryBuilderDsl Of()
        {
            return new NonRecurringOrdersOnlyDraftQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<NonRecurringOrdersOnlyDraftQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<NonRecurringOrdersOnlyDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<NonRecurringOrdersOnlyDraftQueryBuilderDsl>(p, NonRecurringOrdersOnlyDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
