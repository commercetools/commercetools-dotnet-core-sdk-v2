// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.RecurringOrders
{

    public partial class RecurringOrdersOnlyDraftQueryBuilderDsl
    {
        public RecurringOrdersOnlyDraftQueryBuilderDsl()
        {
        }

        public static RecurringOrdersOnlyDraftQueryBuilderDsl Of()
        {
            return new RecurringOrdersOnlyDraftQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<RecurringOrdersOnlyDraftQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<RecurringOrdersOnlyDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<RecurringOrdersOnlyDraftQueryBuilderDsl>(p, RecurringOrdersOnlyDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
