
using System;

namespace commercetools.Sdk.Api.Predicates.Query
{
    public class TimeCollectionPredicateBuilder<T> : ComparableCollectionPredicateBuilder<T, TimeSpan>
    {
        public TimeCollectionPredicateBuilder(BinaryQueryPredicate predicate,
            Func<IQueryPredicate, CombinationQueryPredicate<T>> combinationFn) : base(predicate, combinationFn, PredicateFormatter.Format)
        {
        }
    }

}
