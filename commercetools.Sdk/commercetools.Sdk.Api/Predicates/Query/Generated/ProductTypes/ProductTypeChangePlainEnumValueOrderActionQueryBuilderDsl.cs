using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ProductTypes
{

    public partial class ProductTypeChangePlainEnumValueOrderActionQueryBuilderDsl
    {
        public ProductTypeChangePlainEnumValueOrderActionQueryBuilderDsl()
        {
        }

        public static ProductTypeChangePlainEnumValueOrderActionQueryBuilderDsl Of()
        {
            return new ProductTypeChangePlainEnumValueOrderActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductTypeChangePlainEnumValueOrderActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<ProductTypeChangePlainEnumValueOrderActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<ProductTypeChangePlainEnumValueOrderActionQueryBuilderDsl>(p, ProductTypeChangePlainEnumValueOrderActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductTypeChangePlainEnumValueOrderActionQueryBuilderDsl, string> AttributeName()
        {
            return new ComparisonPredicateBuilder<ProductTypeChangePlainEnumValueOrderActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("attributeName")),
            p => new CombinationQueryPredicate<ProductTypeChangePlainEnumValueOrderActionQueryBuilderDsl>(p, ProductTypeChangePlainEnumValueOrderActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ProductTypeChangePlainEnumValueOrderActionQueryBuilderDsl> Values(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductTypes.AttributePlainEnumValueQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductTypes.AttributePlainEnumValueQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductTypeChangePlainEnumValueOrderActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("values"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductTypes.AttributePlainEnumValueQueryBuilderDsl.Of())),
                ProductTypeChangePlainEnumValueOrderActionQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<ProductTypeChangePlainEnumValueOrderActionQueryBuilderDsl> Values()
        {
            return new CollectionPredicateBuilder<ProductTypeChangePlainEnumValueOrderActionQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("values")),
                    p => new CombinationQueryPredicate<ProductTypeChangePlainEnumValueOrderActionQueryBuilderDsl>(p, ProductTypeChangePlainEnumValueOrderActionQueryBuilderDsl.Of));
        }

    }
}
