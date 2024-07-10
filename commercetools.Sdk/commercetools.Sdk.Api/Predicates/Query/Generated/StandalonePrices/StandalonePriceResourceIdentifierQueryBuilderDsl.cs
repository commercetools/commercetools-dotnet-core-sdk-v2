// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.StandalonePrices
{

    public partial class StandalonePriceResourceIdentifierQueryBuilderDsl
    {
        public StandalonePriceResourceIdentifierQueryBuilderDsl()
        {
        }

        public static StandalonePriceResourceIdentifierQueryBuilderDsl Of()
        {
            return new StandalonePriceResourceIdentifierQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<StandalonePriceResourceIdentifierQueryBuilderDsl, string> TypeId()
        {
            return new ComparisonPredicateBuilder<StandalonePriceResourceIdentifierQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("typeId")),
            p => new CombinationQueryPredicate<StandalonePriceResourceIdentifierQueryBuilderDsl>(p, StandalonePriceResourceIdentifierQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StandalonePriceResourceIdentifierQueryBuilderDsl, string> Id()
        {
            return new ComparisonPredicateBuilder<StandalonePriceResourceIdentifierQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("id")),
            p => new CombinationQueryPredicate<StandalonePriceResourceIdentifierQueryBuilderDsl>(p, StandalonePriceResourceIdentifierQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StandalonePriceResourceIdentifierQueryBuilderDsl, string> Key()
        {
            return new ComparisonPredicateBuilder<StandalonePriceResourceIdentifierQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("key")),
            p => new CombinationQueryPredicate<StandalonePriceResourceIdentifierQueryBuilderDsl>(p, StandalonePriceResourceIdentifierQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
