// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.RecurringOrders
{

    public partial class RecurringOrderResourceIdentifierQueryBuilderDsl
    {
        public RecurringOrderResourceIdentifierQueryBuilderDsl()
        {
        }

        public static RecurringOrderResourceIdentifierQueryBuilderDsl Of()
        {
            return new RecurringOrderResourceIdentifierQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<RecurringOrderResourceIdentifierQueryBuilderDsl, string> TypeId()
        {
            return new ComparisonPredicateBuilder<RecurringOrderResourceIdentifierQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("typeId")),
            p => new CombinationQueryPredicate<RecurringOrderResourceIdentifierQueryBuilderDsl>(p, RecurringOrderResourceIdentifierQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<RecurringOrderResourceIdentifierQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<RecurringOrderResourceIdentifierQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<RecurringOrderResourceIdentifierQueryBuilderDsl>(p, RecurringOrderResourceIdentifierQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<RecurringOrderResourceIdentifierQueryBuilderDsl, string> Key()
        {
            return new ComparisonPredicateBuilder<RecurringOrderResourceIdentifierQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("key")),
            p => new CombinationQueryPredicate<RecurringOrderResourceIdentifierQueryBuilderDsl>(p, RecurringOrderResourceIdentifierQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
