
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.Api.Predicates.Query
{
    public interface IContainsPredicateBuilder<T, in TValue> : IComparablePredicateBuilder<T, TValue> {

    /**
     * create a predicate with the "contains any" operator
     * @param value the values to be contained
     * @return a combination predicate
     */
     CombinationQueryPredicate<T> ContainsAny(IEnumerable<TValue> value) {
        IEnumerable<IQueryPredicate> p = value.Select(Format).ToList();
        ;

        return CombinationFn().Invoke(Predicate().Operator(PredicateOperator.Contains.ToString())
                .Right(ContainerQueryPredicate.Of()
                        .Parent(ConstantQueryPredicate.Of().Constant("any"))
                        .Inner(CollectionQueryPredicate.Of().Predicates(p))));
    }

    /**
     * create a predicate with the "contains all" operator
     * @param value the values to be contained
     * @return a combination predicate
     */
     CombinationQueryPredicate<T> ContainsAll( IEnumerable<TValue> value) {
            IEnumerable<IQueryPredicate> p = value.Select(Format).ToList();
            ;

            return CombinationFn().Invoke(Predicate().Operator(PredicateOperator.Contains.ToString())
                    .Right(ContainerQueryPredicate.Of()
                            .Parent(ConstantQueryPredicate.Of().Constant("all"))
                            .Inner(CollectionQueryPredicate.Of().Predicates(p))));
    }

    /**
     * creates a predicate with the "contains any" operator and the use of a predicate input variable
     * @param variable the variable name
     * @return a combination predicate
     */
     CombinationQueryPredicate<T> ContainsAnyVar( string variable) {
        return CombinationFn().Invoke(Predicate().Operator(PredicateOperator.Contains.ToString())
                .Right(ContainerQueryPredicate.Of()
                        .Parent(ConstantQueryPredicate.Of().Constant("any"))
                        .RenderInnerWithOutParentheses(true)
                        .Inner(VariableQueryPredicate.Of().Variable(variable))));
    }

    /**
     * creates a predicate with the "contains all" operator and the use of a predicate input variable
     * @param variable the variable name
     * @return a combination predicate
     */
     CombinationQueryPredicate<T> ContainsAllVar( string variable) {
            return CombinationFn().Invoke(Predicate().Operator(PredicateOperator.Contains.ToString())
                    .Right(ContainerQueryPredicate.Of()
                            .Parent(ConstantQueryPredicate.Of().Constant("all"))
                            .RenderInnerWithOutParentheses(true)
                            .Inner(VariableQueryPredicate.Of().Variable(variable))));
    }

}

}

