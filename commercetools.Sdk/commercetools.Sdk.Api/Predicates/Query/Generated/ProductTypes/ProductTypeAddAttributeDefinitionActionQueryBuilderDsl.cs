using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ProductTypes
{

    public partial class ProductTypeAddAttributeDefinitionActionQueryBuilderDsl
    {
        public ProductTypeAddAttributeDefinitionActionQueryBuilderDsl()
        {
        }

        public static ProductTypeAddAttributeDefinitionActionQueryBuilderDsl Of()
        {
            return new ProductTypeAddAttributeDefinitionActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductTypeAddAttributeDefinitionActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<ProductTypeAddAttributeDefinitionActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<ProductTypeAddAttributeDefinitionActionQueryBuilderDsl>(p, ProductTypeAddAttributeDefinitionActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ProductTypeAddAttributeDefinitionActionQueryBuilderDsl> Attribute(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductTypes.AttributeDefinitionDraftQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductTypes.AttributeDefinitionDraftQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductTypeAddAttributeDefinitionActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("attribute"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductTypes.AttributeDefinitionDraftQueryBuilderDsl.Of())),
                ProductTypeAddAttributeDefinitionActionQueryBuilderDsl.Of);
        }


    }
}
