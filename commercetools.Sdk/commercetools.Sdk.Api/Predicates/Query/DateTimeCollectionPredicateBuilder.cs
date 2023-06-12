
using System;

namespace commercetools.Sdk.Api.Predicates.Query
{
    public class DateTimeCollectionPredicateBuilder<T> : ComparableCollectionPredicateBuilder<T, DateTime> {
        public DateTimeCollectionPredicateBuilder(BinaryQueryPredicate predicate,
            Func<IQueryPredicate, CombinationQueryPredicate<T>> combinationFn): base(predicate, combinationFn, PredicateFormatter.Format) {
        }
    }
}
