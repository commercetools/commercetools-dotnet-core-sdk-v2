using System;

namespace commercetools.Sdk.Api.Predicates.Query
{
    public interface IPredicateBuilder<T>
    {
        BinaryQueryPredicate Predicate();

        Func<IQueryPredicate, CombinationQueryPredicate<T>> CombinationFn();
    }
}