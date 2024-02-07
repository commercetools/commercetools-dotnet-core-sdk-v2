// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class DiscountCodeKeySetMessagePayloadQueryBuilderDsl
    {
        public DiscountCodeKeySetMessagePayloadQueryBuilderDsl()
        {
        }

        public static DiscountCodeKeySetMessagePayloadQueryBuilderDsl Of()
        {
            return new DiscountCodeKeySetMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<DiscountCodeKeySetMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<DiscountCodeKeySetMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<DiscountCodeKeySetMessagePayloadQueryBuilderDsl>(p, DiscountCodeKeySetMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<DiscountCodeKeySetMessagePayloadQueryBuilderDsl, string> Key()
        {
            return new ComparisonPredicateBuilder<DiscountCodeKeySetMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("key")),
            p => new CombinationQueryPredicate<DiscountCodeKeySetMessagePayloadQueryBuilderDsl>(p, DiscountCodeKeySetMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<DiscountCodeKeySetMessagePayloadQueryBuilderDsl, string> OldKey()
        {
            return new ComparisonPredicateBuilder<DiscountCodeKeySetMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("oldKey")),
            p => new CombinationQueryPredicate<DiscountCodeKeySetMessagePayloadQueryBuilderDsl>(p, DiscountCodeKeySetMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
