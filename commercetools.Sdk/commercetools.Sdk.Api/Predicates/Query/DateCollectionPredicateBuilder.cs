
using System;
using commercetools.Base.Models;

namespace commercetools.Sdk.Api.Predicates.Query
{
    public class DateCollectionPredicateBuilder<T> : ComparableCollectionPredicateBuilder<T, Date>
    {
        public DateCollectionPredicateBuilder(BinaryQueryPredicate predicate,
            Func<IQueryPredicate, CombinationQueryPredicate<T>> combinationFn) : base(predicate, combinationFn, PredicateFormatter.Format)
        {
        }
    }
}


