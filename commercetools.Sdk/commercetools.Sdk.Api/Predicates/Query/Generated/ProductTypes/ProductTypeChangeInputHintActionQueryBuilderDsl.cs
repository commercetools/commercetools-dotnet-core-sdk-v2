using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ProductTypes
{

    public partial class ProductTypeChangeInputHintActionQueryBuilderDsl
    {
        public ProductTypeChangeInputHintActionQueryBuilderDsl()
        {
        }

        public static ProductTypeChangeInputHintActionQueryBuilderDsl Of()
        {
            return new ProductTypeChangeInputHintActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductTypeChangeInputHintActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<ProductTypeChangeInputHintActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<ProductTypeChangeInputHintActionQueryBuilderDsl>(p, ProductTypeChangeInputHintActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductTypeChangeInputHintActionQueryBuilderDsl, string> AttributeName()
        {
            return new ComparisonPredicateBuilder<ProductTypeChangeInputHintActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("attributeName")),
            p => new CombinationQueryPredicate<ProductTypeChangeInputHintActionQueryBuilderDsl>(p, ProductTypeChangeInputHintActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductTypeChangeInputHintActionQueryBuilderDsl, string> NewValue()
        {
            return new ComparisonPredicateBuilder<ProductTypeChangeInputHintActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("newValue")),
            p => new CombinationQueryPredicate<ProductTypeChangeInputHintActionQueryBuilderDsl>(p, ProductTypeChangeInputHintActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
