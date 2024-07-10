using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ProductTypes
{

    public partial class ProductTypeChangeAttributeConstraintActionQueryBuilderDsl
    {
        public ProductTypeChangeAttributeConstraintActionQueryBuilderDsl()
        {
        }

        public static ProductTypeChangeAttributeConstraintActionQueryBuilderDsl Of()
        {
            return new ProductTypeChangeAttributeConstraintActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductTypeChangeAttributeConstraintActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<ProductTypeChangeAttributeConstraintActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<ProductTypeChangeAttributeConstraintActionQueryBuilderDsl>(p, ProductTypeChangeAttributeConstraintActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductTypeChangeAttributeConstraintActionQueryBuilderDsl, string> AttributeName()
        {
            return new ComparisonPredicateBuilder<ProductTypeChangeAttributeConstraintActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("attributeName")),
            p => new CombinationQueryPredicate<ProductTypeChangeAttributeConstraintActionQueryBuilderDsl>(p, ProductTypeChangeAttributeConstraintActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductTypeChangeAttributeConstraintActionQueryBuilderDsl, string> NewValue()
        {
            return new ComparisonPredicateBuilder<ProductTypeChangeAttributeConstraintActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("newValue")),
            p => new CombinationQueryPredicate<ProductTypeChangeAttributeConstraintActionQueryBuilderDsl>(p, ProductTypeChangeAttributeConstraintActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
