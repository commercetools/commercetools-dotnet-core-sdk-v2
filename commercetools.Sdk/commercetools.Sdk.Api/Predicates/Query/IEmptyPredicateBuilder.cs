using System;
using commercetools.Sdk.Api.Models;

namespace commercetools.Sdk.Api.Predicates.Query
{
    public interface IEmptyPredicateBuilder<T> : IPredicateBuilder<T> {
        BinaryQueryPredicate Predicate();

        Func<IQueryPredicate, CombinationQueryPredicate<T>> CombinationFn();

        /**
         * creates predicate to check that an array is empty
         * @return a combination predicate
         */
        CombinationQueryPredicate<T> IsEmpty() {
            return CombinationFn().Invoke(
                Predicate().Operator(PredicateOperator.Is.ToString()).Right(new ConstantQueryPredicate().Constant("empty")));
        }
    }

}