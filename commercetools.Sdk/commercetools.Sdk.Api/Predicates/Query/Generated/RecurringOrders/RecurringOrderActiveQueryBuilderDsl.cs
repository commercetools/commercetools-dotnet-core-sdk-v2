using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.RecurringOrders
{

    public partial class RecurringOrderActiveQueryBuilderDsl
    {
        public RecurringOrderActiveQueryBuilderDsl()
        {
        }

        public static RecurringOrderActiveQueryBuilderDsl Of()
        {
            return new RecurringOrderActiveQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<RecurringOrderActiveQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<RecurringOrderActiveQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<RecurringOrderActiveQueryBuilderDsl>(p, RecurringOrderActiveQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<RecurringOrderActiveQueryBuilderDsl, DateTime> ResumesAt()
        {
            return new ComparisonPredicateBuilder<RecurringOrderActiveQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("resumesAt")),
            p => new CombinationQueryPredicate<RecurringOrderActiveQueryBuilderDsl>(p, RecurringOrderActiveQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
