
using System;

namespace commercetools.Sdk.Api.Predicates.Query
{
    public class DateTimeComparisonPredicateBuilder<T> : ComparisonPredicateBuilder<T, DateTime>, IComparisonPredicateBuilder<T, DateTime>
    {
        public DateTimeComparisonPredicateBuilder(BinaryQueryPredicate predicate,
        Func<IQueryPredicate, CombinationQueryPredicate<T>> combinationFn) : base(predicate, combinationFn, PredicateFormatter.Format)
        {
        }

        public CombinationQueryPredicate<T> IsNot(DateTime value)
        {
            return ((IComparablePredicateBuilder<T, DateTime>)this).Is(PredicateOperator.IsNotEqual, value);
        }
    }
}

