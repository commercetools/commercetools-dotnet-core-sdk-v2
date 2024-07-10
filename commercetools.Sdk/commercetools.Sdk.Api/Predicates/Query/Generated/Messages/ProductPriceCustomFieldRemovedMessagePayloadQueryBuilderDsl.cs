// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class ProductPriceCustomFieldRemovedMessagePayloadQueryBuilderDsl
    {
        public ProductPriceCustomFieldRemovedMessagePayloadQueryBuilderDsl()
        {
        }

        public static ProductPriceCustomFieldRemovedMessagePayloadQueryBuilderDsl Of()
        {
            return new ProductPriceCustomFieldRemovedMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductPriceCustomFieldRemovedMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<ProductPriceCustomFieldRemovedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<ProductPriceCustomFieldRemovedMessagePayloadQueryBuilderDsl>(p, ProductPriceCustomFieldRemovedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductPriceCustomFieldRemovedMessagePayloadQueryBuilderDsl, string> PriceId()
        {
            return new ComparisonPredicateBuilder<ProductPriceCustomFieldRemovedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("priceId")),
            p => new CombinationQueryPredicate<ProductPriceCustomFieldRemovedMessagePayloadQueryBuilderDsl>(p, ProductPriceCustomFieldRemovedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductPriceCustomFieldRemovedMessagePayloadQueryBuilderDsl, long> VariantId()
        {
            return new ComparisonPredicateBuilder<ProductPriceCustomFieldRemovedMessagePayloadQueryBuilderDsl, long>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("variantId")),
            p => new CombinationQueryPredicate<ProductPriceCustomFieldRemovedMessagePayloadQueryBuilderDsl>(p, ProductPriceCustomFieldRemovedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductPriceCustomFieldRemovedMessagePayloadQueryBuilderDsl, bool> Staged()
        {
            return new ComparisonPredicateBuilder<ProductPriceCustomFieldRemovedMessagePayloadQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("staged")),
            p => new CombinationQueryPredicate<ProductPriceCustomFieldRemovedMessagePayloadQueryBuilderDsl>(p, ProductPriceCustomFieldRemovedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductPriceCustomFieldRemovedMessagePayloadQueryBuilderDsl, string> Name()
        {
            return new ComparisonPredicateBuilder<ProductPriceCustomFieldRemovedMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("name")),
            p => new CombinationQueryPredicate<ProductPriceCustomFieldRemovedMessagePayloadQueryBuilderDsl>(p, ProductPriceCustomFieldRemovedMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
