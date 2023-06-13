
using commercetools.Sdk.Api.Models;

namespace commercetools.Sdk.Api.Predicates.Query
{
    public interface IIsDefinedPredicateBuilder<T, in TValue> : IComparablePredicateBuilder<T, TValue> {

     CombinationQueryPredicate<T> IsDefined() {
        return CombinationFn().Invoke(Predicate().Operator(PredicateOperator.Is.ToString())
            .Right(ConstantQueryPredicate.Of().Constant("defined")));
    }

     CombinationQueryPredicate<T> IsNotDefined() {
        return CombinationFn().Invoke(Predicate().Operator(PredicateOperator.Is.ToString())
            .Right(ConstantQueryPredicate.Of().Constant("not defined")));
    }
}
    
}


