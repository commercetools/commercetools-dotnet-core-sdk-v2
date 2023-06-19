namespace commercetools.Sdk.Api.Predicates.Query
{
    public interface IComparablePredicateBuilder<T, in TValue> : IPredicateBuilder<T>
    {
        ConstantQueryPredicate Format(TValue value);

        /**
         * create a predicate with the supplied operator and value
         * @param operator the predicate operator
         * @param value the comparison value
         * @return a combination predicate
         */
        public CombinationQueryPredicate<T> Is(PredicateOperator op, TValue value)
        {
            return CombinationFn().Invoke(Predicate().Operator(op.ToString()).Right(Format(value)));
        }

        /**
         * create a predicate with the supplied operator and variable name predicate
         * @param operator the predicate operator
         * @param value the variable name predicate
         * @return a combination predicate
         */
        public CombinationQueryPredicate<T> Is(PredicateOperator op, VariableQueryPredicate value)
        {
            return CombinationFn().Invoke(Predicate().Operator(op.ToString()).Right(value));
        }
    }
}