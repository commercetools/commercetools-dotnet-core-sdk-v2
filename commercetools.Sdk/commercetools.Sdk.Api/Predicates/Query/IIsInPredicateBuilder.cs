
using System.Collections.Generic;
using System.Linq;
using commercetools.Sdk.Api.Models;

namespace commercetools.Sdk.Api.Predicates.Query
{
    public interface IIsInPredicateBuilder<T, in TValue> : IComparablePredicateBuilder<T, TValue> {

        CombinationQueryPredicate<T> IsIn(IEnumerable<TValue> value) {
            IEnumerable<IQueryPredicate> p = value.Select(Format).ToList();

            return CombinationFn().Invoke(Predicate().Operator(PredicateOperator.IsIn.ToString())
                .Right(ContainerQueryPredicate.Of().Inner(CollectionQueryPredicate.Of().Predicates(p))));
        }

        CombinationQueryPredicate<T> IsInVar(string variable) {
            return CombinationFn().Invoke(Predicate().Operator(PredicateOperator.IsIn.ToString())
                .Right(VariableQueryPredicate.Of().Variable(variable)));
        }

    }
    
}

