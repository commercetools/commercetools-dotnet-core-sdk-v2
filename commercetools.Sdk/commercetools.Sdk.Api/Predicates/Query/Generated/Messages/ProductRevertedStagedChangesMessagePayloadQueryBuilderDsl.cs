using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Messages
{

    public partial class ProductRevertedStagedChangesMessagePayloadQueryBuilderDsl
    {
        public ProductRevertedStagedChangesMessagePayloadQueryBuilderDsl()
        {
        }

        public static ProductRevertedStagedChangesMessagePayloadQueryBuilderDsl Of()
        {
            return new ProductRevertedStagedChangesMessagePayloadQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductRevertedStagedChangesMessagePayloadQueryBuilderDsl, string> Type()
        {
            return new ComparisonPredicateBuilder<ProductRevertedStagedChangesMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("type")),
            p => new CombinationQueryPredicate<ProductRevertedStagedChangesMessagePayloadQueryBuilderDsl>(p, ProductRevertedStagedChangesMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparableCollectionPredicateBuilder<ProductRevertedStagedChangesMessagePayloadQueryBuilderDsl, string> RemovedImageUrls()
        {
            return new ComparableCollectionPredicateBuilder<ProductRevertedStagedChangesMessagePayloadQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("removedImageUrls")),
            p => new CombinationQueryPredicate<ProductRevertedStagedChangesMessagePayloadQueryBuilderDsl>(p, ProductRevertedStagedChangesMessagePayloadQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
