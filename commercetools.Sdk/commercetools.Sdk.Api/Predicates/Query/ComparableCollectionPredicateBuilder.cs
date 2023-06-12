using System;

namespace commercetools.Sdk.Api.Predicates.Query
{
    public class ComparableCollectionPredicateBuilder<T, TValue> : CollectionPredicateBuilder<T>, IComparablePredicateBuilder<T, TValue> {

        private readonly Func<TValue, ConstantQueryPredicate> _formatter;

        public ComparableCollectionPredicateBuilder(BinaryQueryPredicate predicate,
        Func<IQueryPredicate, CombinationQueryPredicate<T>> combinationFn,
            Func<TValue, ConstantQueryPredicate> formatter): base(predicate, combinationFn) {
            this._formatter = formatter;
        }

        public ConstantQueryPredicate Format(TValue value) {
            return _formatter.Invoke(value);
        }
    }   
}