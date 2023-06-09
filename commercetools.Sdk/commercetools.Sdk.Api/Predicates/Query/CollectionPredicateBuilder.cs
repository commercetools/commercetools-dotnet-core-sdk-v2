using System;

namespace commercetools.Sdk.Api.Predicates.Query
{
    public class CollectionPredicateBuilder<T> : IEmptyPredicateBuilder<T> {
        private readonly BinaryQueryPredicate _predicate;

        private readonly Func<IQueryPredicate, CombinationQueryPredicate<T>> _combinationFn;

        public CollectionPredicateBuilder(BinaryQueryPredicate predicate, Func<IQueryPredicate, CombinationQueryPredicate<T>> combinationFn) {
            this._predicate = predicate;
            this._combinationFn = combinationFn;
        }

        public BinaryQueryPredicate Predicate() {
            return _predicate;
        }

        public Func<IQueryPredicate, CombinationQueryPredicate<T>> CombinationFn() {
            return _combinationFn;
        }
    }

}