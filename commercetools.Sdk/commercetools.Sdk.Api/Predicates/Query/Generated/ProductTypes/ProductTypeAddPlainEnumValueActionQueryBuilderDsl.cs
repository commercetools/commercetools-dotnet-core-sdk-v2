using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ProductTypes
{

    public partial class ProductTypeAddPlainEnumValueActionQueryBuilderDsl
    {
        public ProductTypeAddPlainEnumValueActionQueryBuilderDsl()
        {
        }

        public static ProductTypeAddPlainEnumValueActionQueryBuilderDsl Of()
        {
            return new ProductTypeAddPlainEnumValueActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductTypeAddPlainEnumValueActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<ProductTypeAddPlainEnumValueActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<ProductTypeAddPlainEnumValueActionQueryBuilderDsl>(p, ProductTypeAddPlainEnumValueActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductTypeAddPlainEnumValueActionQueryBuilderDsl, string> AttributeName()
        {
            return new ComparisonPredicateBuilder<ProductTypeAddPlainEnumValueActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("attributeName")),
            p => new CombinationQueryPredicate<ProductTypeAddPlainEnumValueActionQueryBuilderDsl>(p, ProductTypeAddPlainEnumValueActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ProductTypeAddPlainEnumValueActionQueryBuilderDsl> Value(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductTypes.AttributePlainEnumValueQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductTypes.AttributePlainEnumValueQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductTypeAddPlainEnumValueActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("value"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductTypes.AttributePlainEnumValueQueryBuilderDsl.Of())),
                ProductTypeAddPlainEnumValueActionQueryBuilderDsl.Of);
        }


    }
}
