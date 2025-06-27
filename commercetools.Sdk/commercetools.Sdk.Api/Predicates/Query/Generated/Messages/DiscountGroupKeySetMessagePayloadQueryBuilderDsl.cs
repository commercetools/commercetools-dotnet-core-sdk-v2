// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class DiscountGroupKeySetMessagePayloadQueryBuilderDsl
    {
        public DiscountGroupKeySetMessagePayloadQueryBuilderDsl()
        {
        }

        public static DiscountGroupKeySetMessagePayloadQueryBuilderDsl Of()
        {
            return new DiscountGroupKeySetMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<DiscountGroupKeySetMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<DiscountGroupKeySetMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<DiscountGroupKeySetMessagePayloadQueryBuilderDsl>(p, DiscountGroupKeySetMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<DiscountGroupKeySetMessagePayloadQueryBuilderDsl, string> Key()
        {
            return new ComparisonPredicateBuilder<DiscountGroupKeySetMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("key")),
            p => new CombinationQueryPredicate<DiscountGroupKeySetMessagePayloadQueryBuilderDsl>(p, DiscountGroupKeySetMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<DiscountGroupKeySetMessagePayloadQueryBuilderDsl, string> OldKey()
        {
            return new ComparisonPredicateBuilder<DiscountGroupKeySetMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("oldKey")),
            p => new CombinationQueryPredicate<DiscountGroupKeySetMessagePayloadQueryBuilderDsl>(p, DiscountGroupKeySetMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
