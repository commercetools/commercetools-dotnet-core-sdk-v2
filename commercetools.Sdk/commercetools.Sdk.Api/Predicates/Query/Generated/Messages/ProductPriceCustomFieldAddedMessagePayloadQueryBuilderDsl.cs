// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class ProductPriceCustomFieldAddedMessagePayloadQueryBuilderDsl
    {
        public ProductPriceCustomFieldAddedMessagePayloadQueryBuilderDsl()
        {
        }

        public static ProductPriceCustomFieldAddedMessagePayloadQueryBuilderDsl Of()
        {
            return new ProductPriceCustomFieldAddedMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductPriceCustomFieldAddedMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<ProductPriceCustomFieldAddedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<ProductPriceCustomFieldAddedMessagePayloadQueryBuilderDsl>(p, ProductPriceCustomFieldAddedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductPriceCustomFieldAddedMessagePayloadQueryBuilderDsl, string> PriceId()
        {
            return new ComparisonPredicateBuilder<ProductPriceCustomFieldAddedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("priceId")),
            p => new CombinationQueryPredicate<ProductPriceCustomFieldAddedMessagePayloadQueryBuilderDsl>(p, ProductPriceCustomFieldAddedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductPriceCustomFieldAddedMessagePayloadQueryBuilderDsl, long> VariantId()
        {
            return new ComparisonPredicateBuilder<ProductPriceCustomFieldAddedMessagePayloadQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("variantId")),
            p => new CombinationQueryPredicate<ProductPriceCustomFieldAddedMessagePayloadQueryBuilderDsl>(p, ProductPriceCustomFieldAddedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductPriceCustomFieldAddedMessagePayloadQueryBuilderDsl, bool> Staged()
        {
            return new ComparisonPredicateBuilder<ProductPriceCustomFieldAddedMessagePayloadQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("staged")),
            p => new CombinationQueryPredicate<ProductPriceCustomFieldAddedMessagePayloadQueryBuilderDsl>(p, ProductPriceCustomFieldAddedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductPriceCustomFieldAddedMessagePayloadQueryBuilderDsl, string> Name()
        {
            return new ComparisonPredicateBuilder<ProductPriceCustomFieldAddedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("name")),
            p => new CombinationQueryPredicate<ProductPriceCustomFieldAddedMessagePayloadQueryBuilderDsl>(p, ProductPriceCustomFieldAddedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductPriceCustomFieldAddedMessagePayloadQueryBuilderDsl, string> Value()
        {
            return new ComparisonPredicateBuilder<ProductPriceCustomFieldAddedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("value")),
            p => new CombinationQueryPredicate<ProductPriceCustomFieldAddedMessagePayloadQueryBuilderDsl>(p, ProductPriceCustomFieldAddedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
