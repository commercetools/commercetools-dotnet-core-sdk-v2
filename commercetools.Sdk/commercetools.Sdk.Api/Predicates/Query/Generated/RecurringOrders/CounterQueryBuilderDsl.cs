using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.RecurringOrders
{

    public partial class CounterQueryBuilderDsl
    {
        public CounterQueryBuilderDsl()
        {
        }

        public static CounterQueryBuilderDsl Of()
        {
            return new CounterQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CounterQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<CounterQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<CounterQueryBuilderDsl>(p, CounterQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CounterQueryBuilderDsl, long> TotalToSkip()
        {
            return new ComparisonPredicateBuilder<CounterQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("totalToSkip")),
            p => new CombinationQueryPredicate<CounterQueryBuilderDsl>(p, CounterQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CounterQueryBuilderDsl, long> Skipped()
        {
            return new ComparisonPredicateBuilder<CounterQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("skipped")),
            p => new CombinationQueryPredicate<CounterQueryBuilderDsl>(p, CounterQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CounterQueryBuilderDsl, DateTime> LastSkippedAt()
        {
            return new ComparisonPredicateBuilder<CounterQueryBuilderDsl, DateTime>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lastSkippedAt")),
            p => new CombinationQueryPredicate<CounterQueryBuilderDsl>(p, CounterQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
