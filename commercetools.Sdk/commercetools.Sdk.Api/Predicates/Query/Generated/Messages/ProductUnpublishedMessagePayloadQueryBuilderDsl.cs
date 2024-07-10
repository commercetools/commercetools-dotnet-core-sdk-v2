// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class ProductUnpublishedMessagePayloadQueryBuilderDsl
    {
        public ProductUnpublishedMessagePayloadQueryBuilderDsl()
        {
        }

        public static ProductUnpublishedMessagePayloadQueryBuilderDsl Of()
        {
            return new ProductUnpublishedMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductUnpublishedMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<ProductUnpublishedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<ProductUnpublishedMessagePayloadQueryBuilderDsl>(p, ProductUnpublishedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
