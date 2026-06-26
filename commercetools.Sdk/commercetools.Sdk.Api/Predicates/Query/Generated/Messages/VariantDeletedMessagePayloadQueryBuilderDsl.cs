// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class VariantDeletedMessagePayloadQueryBuilderDsl
    {
        public VariantDeletedMessagePayloadQueryBuilderDsl()
        {
        }

        public static VariantDeletedMessagePayloadQueryBuilderDsl Of()
        {
            return new VariantDeletedMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<VariantDeletedMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<VariantDeletedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<VariantDeletedMessagePayloadQueryBuilderDsl>(p, VariantDeletedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
