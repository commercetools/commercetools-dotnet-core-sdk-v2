using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ProductTypes
{

    public partial class ProductTypeChangeLocalizedEnumValueOrderActionQueryBuilderDsl
    {
        public ProductTypeChangeLocalizedEnumValueOrderActionQueryBuilderDsl()
        {
        }

        public static ProductTypeChangeLocalizedEnumValueOrderActionQueryBuilderDsl Of()
        {
            return new ProductTypeChangeLocalizedEnumValueOrderActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductTypeChangeLocalizedEnumValueOrderActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<ProductTypeChangeLocalizedEnumValueOrderActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<ProductTypeChangeLocalizedEnumValueOrderActionQueryBuilderDsl>(p, ProductTypeChangeLocalizedEnumValueOrderActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductTypeChangeLocalizedEnumValueOrderActionQueryBuilderDsl, string> AttributeName()
        {
            return new ComparisonPredicateBuilder<ProductTypeChangeLocalizedEnumValueOrderActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("attributeName")),
            p => new CombinationQueryPredicate<ProductTypeChangeLocalizedEnumValueOrderActionQueryBuilderDsl>(p, ProductTypeChangeLocalizedEnumValueOrderActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ProductTypeChangeLocalizedEnumValueOrderActionQueryBuilderDsl> Values(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductTypes.AttributeLocalizedEnumValueQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductTypes.AttributeLocalizedEnumValueQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductTypeChangeLocalizedEnumValueOrderActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("values"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductTypes.AttributeLocalizedEnumValueQueryBuilderDsl.Of())),
                ProductTypeChangeLocalizedEnumValueOrderActionQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<ProductTypeChangeLocalizedEnumValueOrderActionQueryBuilderDsl> Values()
        {
            return new CollectionPredicateBuilder<ProductTypeChangeLocalizedEnumValueOrderActionQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("values")),
                    p => new CombinationQueryPredicate<ProductTypeChangeLocalizedEnumValueOrderActionQueryBuilderDsl>(p, ProductTypeChangeLocalizedEnumValueOrderActionQueryBuilderDsl.Of));
        }

    }
}
