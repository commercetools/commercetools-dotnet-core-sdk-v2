namespace commercetools.Sdk.Api.Predicates.Query
{
    public interface IComparisonPredicateBuilder<T, in TValue> : IEqualityPredicateBuilder<T, TValue>,
        IInequalityPredicateBuilder<T, TValue>,
        INotEqualPredicateBuilder<T, TValue>,
        IIsInPredicateBuilder<T, TValue>,
        IIsDefinedPredicateBuilder<T, TValue>
    {
    }
}