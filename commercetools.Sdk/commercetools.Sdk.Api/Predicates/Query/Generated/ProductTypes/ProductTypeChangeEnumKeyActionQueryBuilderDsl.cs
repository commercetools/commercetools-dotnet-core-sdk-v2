using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ProductTypes
{

    public partial class ProductTypeChangeEnumKeyActionQueryBuilderDsl
    {
        public ProductTypeChangeEnumKeyActionQueryBuilderDsl()
        {
        }

        public static ProductTypeChangeEnumKeyActionQueryBuilderDsl Of()
        {
            return new ProductTypeChangeEnumKeyActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductTypeChangeEnumKeyActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<ProductTypeChangeEnumKeyActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<ProductTypeChangeEnumKeyActionQueryBuilderDsl>(p, ProductTypeChangeEnumKeyActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductTypeChangeEnumKeyActionQueryBuilderDsl, string> AttributeName()
        {
            return new ComparisonPredicateBuilder<ProductTypeChangeEnumKeyActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("attributeName")),
            p => new CombinationQueryPredicate<ProductTypeChangeEnumKeyActionQueryBuilderDsl>(p, ProductTypeChangeEnumKeyActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductTypeChangeEnumKeyActionQueryBuilderDsl, string> Key()
        {
            return new ComparisonPredicateBuilder<ProductTypeChangeEnumKeyActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("key")),
            p => new CombinationQueryPredicate<ProductTypeChangeEnumKeyActionQueryBuilderDsl>(p, ProductTypeChangeEnumKeyActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductTypeChangeEnumKeyActionQueryBuilderDsl, string> NewKey()
        {
            return new ComparisonPredicateBuilder<ProductTypeChangeEnumKeyActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("newKey")),
            p => new CombinationQueryPredicate<ProductTypeChangeEnumKeyActionQueryBuilderDsl>(p, ProductTypeChangeEnumKeyActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
