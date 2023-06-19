
using System;
using commercetools.Base.Models;

namespace commercetools.Sdk.Api.Predicates.Query
{
    public interface INotEqualPredicateBuilder<T, in TValue> : IComparablePredicateBuilder<T, TValue>
    {
        CombinationQueryPredicate<T> IsNot(TValue value)
        {
            if (value is string || value is DateTime || value is TimeSpan || value is Date)
            {
                return Is(PredicateOperator.IsNotEqual, value);
            }
            return Is(PredicateOperator.IsNot, value);
        }

        CombinationQueryPredicate<T> IsNotVar(string variable)
        {
            return Is(PredicateOperator.IsNot, VariableQueryPredicate.Of().Variable(variable));
        }
    }

}

