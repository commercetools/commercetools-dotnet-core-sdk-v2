using System;

namespace commercetools.Sdk.Api.Predicates.Query
{
    public interface IComparableCollectionPredicateBuilder<T, in TValue> : IContainsPredicateBuilder<T, TValue>, ICollectionPredicateBuilder<T> {
    }   
}