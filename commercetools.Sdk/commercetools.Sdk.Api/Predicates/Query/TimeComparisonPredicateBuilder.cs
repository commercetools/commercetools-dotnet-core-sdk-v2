
using System;

namespace commercetools.Sdk.Api.Predicates.Query
{
    public class TimeComparisonPredicateBuilder<T> : ComparablePredicateBuilder<T, TimeSpan> {
        public TimeComparisonPredicateBuilder(BinaryQueryPredicate predicate,
            Func<IQueryPredicate, CombinationQueryPredicate<T>> combinationFn): base(predicate, combinationFn, PredicateFormatter.Format) {
        }

        public CombinationQueryPredicate<T> IsNot(TimeSpan value) {
            return  ((IComparablePredicateBuilder<T, TimeSpan>)this).Is(PredicateOperator.IsNotEqual, value);
        }
    }
}
