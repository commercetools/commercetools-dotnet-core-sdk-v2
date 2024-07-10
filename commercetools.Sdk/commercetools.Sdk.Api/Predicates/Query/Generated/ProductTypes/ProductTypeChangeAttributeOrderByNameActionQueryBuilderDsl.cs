using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ProductTypes
{

    public partial class ProductTypeChangeAttributeOrderByNameActionQueryBuilderDsl
    {
        public ProductTypeChangeAttributeOrderByNameActionQueryBuilderDsl()
        {
        }

        public static ProductTypeChangeAttributeOrderByNameActionQueryBuilderDsl Of()
        {
            return new ProductTypeChangeAttributeOrderByNameActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductTypeChangeAttributeOrderByNameActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<ProductTypeChangeAttributeOrderByNameActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<ProductTypeChangeAttributeOrderByNameActionQueryBuilderDsl>(p, ProductTypeChangeAttributeOrderByNameActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparableCollectionPredicateBuilder<ProductTypeChangeAttributeOrderByNameActionQueryBuilderDsl, string> AttributeNames()
        {
            return new ComparableCollectionPredicateBuilder<ProductTypeChangeAttributeOrderByNameActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("attributeNames")),
            p => new CombinationQueryPredicate<ProductTypeChangeAttributeOrderByNameActionQueryBuilderDsl>(p, ProductTypeChangeAttributeOrderByNameActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
