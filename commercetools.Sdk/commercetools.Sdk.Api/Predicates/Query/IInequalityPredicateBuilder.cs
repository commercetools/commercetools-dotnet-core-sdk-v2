namespace commercetools.Sdk.Api.Predicates.Query
{
    public interface IInequalityPredicateBuilder<T, in TValue> : IComparablePredicateBuilder<T, TValue>
    {
        CombinationQueryPredicate<T> IsLessThan(TValue value)
        {
            return Is(PredicateOperator.IsLessThan, value);
        }

        CombinationQueryPredicate<T> IsGreaterThan(TValue value)
        {
            return Is(PredicateOperator.IsGreaterThan, value);
        }

        CombinationQueryPredicate<T> IsLessThanOrEqual(TValue value)
        {
            return Is(PredicateOperator.IsLessThanOrEqual, value);
        }

        CombinationQueryPredicate<T> IsGreaterThanOrEqual(TValue value)
        {
            return Is(PredicateOperator.IsGreaterThanOrEqual, value);
        }

        CombinationQueryPredicate<T> IsLessThanVar(string variable)
        {
            return Is(PredicateOperator.IsLessThan, new VariableQueryPredicate().Variable(variable));
        }

        CombinationQueryPredicate<T> IsGreaterThanVar(string variable)
        {
            return Is(PredicateOperator.IsGreaterThan, new VariableQueryPredicate().Variable(variable));
        }

        CombinationQueryPredicate<T> IsLessThanOrEqualVar(string variable)
        {
            return Is(PredicateOperator.IsLessThanOrEqual, new VariableQueryPredicate().Variable(variable));
        }

        CombinationQueryPredicate<T> IsGreaterThanOrEqualVar(string variable)
        {
            return Is(PredicateOperator.IsGreaterThanOrEqual, new VariableQueryPredicate().Variable(variable));
        }
    }
}