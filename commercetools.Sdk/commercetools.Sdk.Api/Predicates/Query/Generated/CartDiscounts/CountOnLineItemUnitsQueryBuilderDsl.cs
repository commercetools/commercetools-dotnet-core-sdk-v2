// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.CartDiscounts
{

    public partial class CountOnLineItemUnitsQueryBuilderDsl
    {
        public CountOnLineItemUnitsQueryBuilderDsl()
        {
        }

        public static CountOnLineItemUnitsQueryBuilderDsl Of()
        {
            return new CountOnLineItemUnitsQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CountOnLineItemUnitsQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<CountOnLineItemUnitsQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<CountOnLineItemUnitsQueryBuilderDsl>(p, CountOnLineItemUnitsQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CountOnLineItemUnitsQueryBuilderDsl, string> Predicate()
        {
            return new ComparisonPredicateBuilder<CountOnLineItemUnitsQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("predicate")),
            p => new CombinationQueryPredicate<CountOnLineItemUnitsQueryBuilderDsl>(p, CountOnLineItemUnitsQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CountOnLineItemUnitsQueryBuilderDsl, long> MinCount()
        {
            return new ComparisonPredicateBuilder<CountOnLineItemUnitsQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("minCount")),
            p => new CombinationQueryPredicate<CountOnLineItemUnitsQueryBuilderDsl>(p, CountOnLineItemUnitsQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CountOnLineItemUnitsQueryBuilderDsl, long> MaxCount()
        {
            return new ComparisonPredicateBuilder<CountOnLineItemUnitsQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("maxCount")),
            p => new CombinationQueryPredicate<CountOnLineItemUnitsQueryBuilderDsl>(p, CountOnLineItemUnitsQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CountOnLineItemUnitsQueryBuilderDsl, long> ExcludeCount()
        {
            return new ComparisonPredicateBuilder<CountOnLineItemUnitsQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("excludeCount")),
            p => new CombinationQueryPredicate<CountOnLineItemUnitsQueryBuilderDsl>(p, CountOnLineItemUnitsQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
