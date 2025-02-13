
using System;
using commercetools.Base.Models;

namespace commercetools.Sdk.Api.Predicates.Query
{
    public class DateComparisonPredicateBuilder<T> : ComparisonPredicateBuilder<T, Date>, IComparisonPredicateBuilder<T, Date>
    {
        public DateComparisonPredicateBuilder(BinaryQueryPredicate predicate, Func<IQueryPredicate, CombinationQueryPredicate<T>> combinationFn) : base(predicate, combinationFn, PredicateFormatter.Format)
        {
        }

        public CombinationQueryPredicate<T> IsNot(Date value)
        {
            return ((IComparablePredicateBuilder<T, Date>)this).Is(PredicateOperator.IsNotEqual, value);
        }
    }

}
