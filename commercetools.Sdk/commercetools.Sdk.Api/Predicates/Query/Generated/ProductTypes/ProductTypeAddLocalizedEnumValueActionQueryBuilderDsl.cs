using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ProductTypes
{

    public partial class ProductTypeAddLocalizedEnumValueActionQueryBuilderDsl
    {
        public ProductTypeAddLocalizedEnumValueActionQueryBuilderDsl()
        {
        }

        public static ProductTypeAddLocalizedEnumValueActionQueryBuilderDsl Of()
        {
            return new ProductTypeAddLocalizedEnumValueActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductTypeAddLocalizedEnumValueActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<ProductTypeAddLocalizedEnumValueActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<ProductTypeAddLocalizedEnumValueActionQueryBuilderDsl>(p, ProductTypeAddLocalizedEnumValueActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductTypeAddLocalizedEnumValueActionQueryBuilderDsl, string> AttributeName()
        {
            return new ComparisonPredicateBuilder<ProductTypeAddLocalizedEnumValueActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("attributeName")),
            p => new CombinationQueryPredicate<ProductTypeAddLocalizedEnumValueActionQueryBuilderDsl>(p, ProductTypeAddLocalizedEnumValueActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ProductTypeAddLocalizedEnumValueActionQueryBuilderDsl> Value(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductTypes.AttributeLocalizedEnumValueQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductTypes.AttributeLocalizedEnumValueQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductTypeAddLocalizedEnumValueActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("value"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductTypes.AttributeLocalizedEnumValueQueryBuilderDsl.Of())),
                ProductTypeAddLocalizedEnumValueActionQueryBuilderDsl.Of);
        }


    }
}
