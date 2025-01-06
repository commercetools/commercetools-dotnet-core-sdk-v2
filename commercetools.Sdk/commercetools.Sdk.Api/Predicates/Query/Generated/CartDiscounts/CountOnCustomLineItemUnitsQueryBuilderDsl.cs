// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.CartDiscounts
{

    public partial class CountOnCustomLineItemUnitsQueryBuilderDsl
    {
        public CountOnCustomLineItemUnitsQueryBuilderDsl()
        {
        }

        public static CountOnCustomLineItemUnitsQueryBuilderDsl Of()
        {
            return new CountOnCustomLineItemUnitsQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<CountOnCustomLineItemUnitsQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<CountOnCustomLineItemUnitsQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<CountOnCustomLineItemUnitsQueryBuilderDsl>(p, CountOnCustomLineItemUnitsQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CountOnCustomLineItemUnitsQueryBuilderDsl, string> Predicate()
        {
            return new ComparisonPredicateBuilder<CountOnCustomLineItemUnitsQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("predicate")),
            p => new CombinationQueryPredicate<CountOnCustomLineItemUnitsQueryBuilderDsl>(p, CountOnCustomLineItemUnitsQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CountOnCustomLineItemUnitsQueryBuilderDsl, long> MinCount()
        {
            return new ComparisonPredicateBuilder<CountOnCustomLineItemUnitsQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("minCount")),
            p => new CombinationQueryPredicate<CountOnCustomLineItemUnitsQueryBuilderDsl>(p, CountOnCustomLineItemUnitsQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CountOnCustomLineItemUnitsQueryBuilderDsl, long> MaxCount()
        {
            return new ComparisonPredicateBuilder<CountOnCustomLineItemUnitsQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("maxCount")),
            p => new CombinationQueryPredicate<CountOnCustomLineItemUnitsQueryBuilderDsl>(p, CountOnCustomLineItemUnitsQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<CountOnCustomLineItemUnitsQueryBuilderDsl, long> ExcludeCount()
        {
            return new ComparisonPredicateBuilder<CountOnCustomLineItemUnitsQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("excludeCount")),
            p => new CombinationQueryPredicate<CountOnCustomLineItemUnitsQueryBuilderDsl>(p, CountOnCustomLineItemUnitsQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
