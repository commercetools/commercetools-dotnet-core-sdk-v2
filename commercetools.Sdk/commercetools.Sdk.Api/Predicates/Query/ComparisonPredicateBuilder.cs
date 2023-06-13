using System;

namespace commercetools.Sdk.Api.Predicates.Query
{
    public class ComparisonPredicateBuilder<T, TValue> : IComparisonPredicateBuilder<T, TValue> {
        private readonly BinaryQueryPredicate _predicate;

        private readonly Func<IQueryPredicate, CombinationQueryPredicate<T>> _combinationFn;

        private readonly Func<TValue, ConstantQueryPredicate> _formatter;

        public ComparisonPredicateBuilder( BinaryQueryPredicate predicate, 
            Func<IQueryPredicate, CombinationQueryPredicate<T>> combinationFn, 
            Func<TValue, ConstantQueryPredicate> formatter) {
            this._predicate = predicate;
            this._combinationFn = combinationFn;
            this._formatter = formatter;
        }

        public BinaryQueryPredicate Predicate() {
            return _predicate;
        }

        public Func<IQueryPredicate, CombinationQueryPredicate<T>> CombinationFn() {
            return _combinationFn;
        }

        public ConstantQueryPredicate Format( TValue value) {
            return _formatter.Invoke(value);
        }
    }
}