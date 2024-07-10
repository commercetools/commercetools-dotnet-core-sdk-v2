using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ProductTypes
{

    public partial class ProductTypeChangeNameActionQueryBuilderDsl
    {
        public ProductTypeChangeNameActionQueryBuilderDsl()
        {
        }

        public static ProductTypeChangeNameActionQueryBuilderDsl Of()
        {
            return new ProductTypeChangeNameActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductTypeChangeNameActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<ProductTypeChangeNameActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<ProductTypeChangeNameActionQueryBuilderDsl>(p, ProductTypeChangeNameActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductTypeChangeNameActionQueryBuilderDsl, string> Name()
        {
            return new ComparisonPredicateBuilder<ProductTypeChangeNameActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("name")),
            p => new CombinationQueryPredicate<ProductTypeChangeNameActionQueryBuilderDsl>(p, ProductTypeChangeNameActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
