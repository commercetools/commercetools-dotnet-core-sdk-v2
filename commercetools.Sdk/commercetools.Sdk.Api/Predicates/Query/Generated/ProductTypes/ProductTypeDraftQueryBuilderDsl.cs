using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ProductTypes
{

    public partial class ProductTypeDraftQueryBuilderDsl
    {
        public ProductTypeDraftQueryBuilderDsl()
        {
        }

        public static ProductTypeDraftQueryBuilderDsl Of()
        {
            return new ProductTypeDraftQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductTypeDraftQueryBuilderDsl, string> Key()
        {
            return new ComparisonPredicateBuilder<ProductTypeDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("key")),
            p => new CombinationQueryPredicate<ProductTypeDraftQueryBuilderDsl>(p, ProductTypeDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductTypeDraftQueryBuilderDsl, string> Name()
        {
            return new ComparisonPredicateBuilder<ProductTypeDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("name")),
            p => new CombinationQueryPredicate<ProductTypeDraftQueryBuilderDsl>(p, ProductTypeDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductTypeDraftQueryBuilderDsl, string> Description()
        {
            return new ComparisonPredicateBuilder<ProductTypeDraftQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("description")),
            p => new CombinationQueryPredicate<ProductTypeDraftQueryBuilderDsl>(p, ProductTypeDraftQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ProductTypeDraftQueryBuilderDsl> Attributes(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductTypes.AttributeDefinitionDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductTypes.AttributeDefinitionDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductTypeDraftQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("attributes"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductTypes.AttributeDefinitionDraftQueryBuilderDsl.Of())),
                ProductTypeDraftQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<ProductTypeDraftQueryBuilderDsl> Attributes()
        {
            return new CollectionPredicateBuilder<ProductTypeDraftQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("attributes")),
                    p => new CombinationQueryPredicate<ProductTypeDraftQueryBuilderDsl>(p, ProductTypeDraftQueryBuilderDsl.Of));
        }

    }
}
