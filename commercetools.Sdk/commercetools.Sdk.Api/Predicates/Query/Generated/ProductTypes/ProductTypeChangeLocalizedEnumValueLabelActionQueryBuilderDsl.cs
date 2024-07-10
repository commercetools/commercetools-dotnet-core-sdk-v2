using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ProductTypes
{

    public partial class ProductTypeChangeLocalizedEnumValueLabelActionQueryBuilderDsl
    {
        public ProductTypeChangeLocalizedEnumValueLabelActionQueryBuilderDsl()
        {
        }

        public static ProductTypeChangeLocalizedEnumValueLabelActionQueryBuilderDsl Of()
        {
            return new ProductTypeChangeLocalizedEnumValueLabelActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductTypeChangeLocalizedEnumValueLabelActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<ProductTypeChangeLocalizedEnumValueLabelActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<ProductTypeChangeLocalizedEnumValueLabelActionQueryBuilderDsl>(p, ProductTypeChangeLocalizedEnumValueLabelActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductTypeChangeLocalizedEnumValueLabelActionQueryBuilderDsl, string> AttributeName()
        {
            return new ComparisonPredicateBuilder<ProductTypeChangeLocalizedEnumValueLabelActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("attributeName")),
            p => new CombinationQueryPredicate<ProductTypeChangeLocalizedEnumValueLabelActionQueryBuilderDsl>(p, ProductTypeChangeLocalizedEnumValueLabelActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ProductTypeChangeLocalizedEnumValueLabelActionQueryBuilderDsl> NewValue(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductTypes.AttributeLocalizedEnumValueQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductTypes.AttributeLocalizedEnumValueQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductTypeChangeLocalizedEnumValueLabelActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("newValue"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductTypes.AttributeLocalizedEnumValueQueryBuilderDsl.Of())),
                ProductTypeChangeLocalizedEnumValueLabelActionQueryBuilderDsl.Of);
        }


    }
}
