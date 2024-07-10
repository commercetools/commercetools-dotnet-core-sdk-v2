using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ProductTypes
{

    public partial class ProductTypeChangePlainEnumValueLabelActionQueryBuilderDsl
    {
        public ProductTypeChangePlainEnumValueLabelActionQueryBuilderDsl()
        {
        }

        public static ProductTypeChangePlainEnumValueLabelActionQueryBuilderDsl Of()
        {
            return new ProductTypeChangePlainEnumValueLabelActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductTypeChangePlainEnumValueLabelActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<ProductTypeChangePlainEnumValueLabelActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<ProductTypeChangePlainEnumValueLabelActionQueryBuilderDsl>(p, ProductTypeChangePlainEnumValueLabelActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductTypeChangePlainEnumValueLabelActionQueryBuilderDsl, string> AttributeName()
        {
            return new ComparisonPredicateBuilder<ProductTypeChangePlainEnumValueLabelActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("attributeName")),
            p => new CombinationQueryPredicate<ProductTypeChangePlainEnumValueLabelActionQueryBuilderDsl>(p, ProductTypeChangePlainEnumValueLabelActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ProductTypeChangePlainEnumValueLabelActionQueryBuilderDsl> NewValue(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductTypes.AttributePlainEnumValueQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductTypes.AttributePlainEnumValueQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductTypeChangePlainEnumValueLabelActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("newValue"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductTypes.AttributePlainEnumValueQueryBuilderDsl.Of())),
                ProductTypeChangePlainEnumValueLabelActionQueryBuilderDsl.Of);
        }


    }
}
