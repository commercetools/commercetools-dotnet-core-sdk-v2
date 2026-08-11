// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class VariantKeySetMessagePayloadQueryBuilderDsl
    {
        public VariantKeySetMessagePayloadQueryBuilderDsl()
        {
        }

        public static VariantKeySetMessagePayloadQueryBuilderDsl Of()
        {
            return new VariantKeySetMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<VariantKeySetMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<VariantKeySetMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<VariantKeySetMessagePayloadQueryBuilderDsl>(p, VariantKeySetMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<VariantKeySetMessagePayloadQueryBuilderDsl, string> Key()
        {
            return new ComparisonPredicateBuilder<VariantKeySetMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("key")),
            p => new CombinationQueryPredicate<VariantKeySetMessagePayloadQueryBuilderDsl>(p, VariantKeySetMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<VariantKeySetMessagePayloadQueryBuilderDsl, string> OldKey()
        {
            return new ComparisonPredicateBuilder<VariantKeySetMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("oldKey")),
            p => new CombinationQueryPredicate<VariantKeySetMessagePayloadQueryBuilderDsl>(p, VariantKeySetMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
