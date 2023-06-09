namespace commercetools.Sdk.Api.Predicates.Query
{
    public interface IEqualityPredicateBuilder<T, in TValue> : IComparablePredicateBuilder<T, TValue> {

        /**
         * creates predicate to a field has the specified value
         * @param value value to be checked for equality
         * @return a combination predicate
         */
        CombinationQueryPredicate<T> Is(TValue value) {
        return Is(PredicateOperator.IsEqual, value);
        }

        /**
         * creates predicate to a field has the value of the supplied variable
         * @param variable variable name
         * @return a combination predicate
         */
        CombinationQueryPredicate<T> IsVar(string variable) {
            return Is(PredicateOperator.IsEqual, new VariableQueryPredicate().Constant(variable));
        }
    }
}