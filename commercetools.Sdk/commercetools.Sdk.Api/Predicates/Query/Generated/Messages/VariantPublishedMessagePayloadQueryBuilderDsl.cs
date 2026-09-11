// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class VariantPublishedMessagePayloadQueryBuilderDsl
    {
        public VariantPublishedMessagePayloadQueryBuilderDsl()
        {
        }

        public static VariantPublishedMessagePayloadQueryBuilderDsl Of()
        {
            return new VariantPublishedMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<VariantPublishedMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<VariantPublishedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<VariantPublishedMessagePayloadQueryBuilderDsl>(p, VariantPublishedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
