using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Products
{

    public partial class ProductSetProductPriceCustomFieldActionQueryBuilderDsl
    {
        public ProductSetProductPriceCustomFieldActionQueryBuilderDsl()
        {
        }

        public static ProductSetProductPriceCustomFieldActionQueryBuilderDsl Of()
        {
            return new ProductSetProductPriceCustomFieldActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductSetProductPriceCustomFieldActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<ProductSetProductPriceCustomFieldActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<ProductSetProductPriceCustomFieldActionQueryBuilderDsl>(p, ProductSetProductPriceCustomFieldActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductSetProductPriceCustomFieldActionQueryBuilderDsl, string> PriceId()
        {
            return new ComparisonPredicateBuilder<ProductSetProductPriceCustomFieldActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("priceId")),
            p => new CombinationQueryPredicate<ProductSetProductPriceCustomFieldActionQueryBuilderDsl>(p, ProductSetProductPriceCustomFieldActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductSetProductPriceCustomFieldActionQueryBuilderDsl, bool> Staged()
        {
            return new ComparisonPredicateBuilder<ProductSetProductPriceCustomFieldActionQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("staged")),
            p => new CombinationQueryPredicate<ProductSetProductPriceCustomFieldActionQueryBuilderDsl>(p, ProductSetProductPriceCustomFieldActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductSetProductPriceCustomFieldActionQueryBuilderDsl, string> Name()
        {
            return new ComparisonPredicateBuilder<ProductSetProductPriceCustomFieldActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("name")),
            p => new CombinationQueryPredicate<ProductSetProductPriceCustomFieldActionQueryBuilderDsl>(p, ProductSetProductPriceCustomFieldActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<ProductSetProductPriceCustomFieldActionQueryBuilderDsl, string> Value()
        {
            return new ComparisonPredicateBuilder<ProductSetProductPriceCustomFieldActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("value")),
            p => new CombinationQueryPredicate<ProductSetProductPriceCustomFieldActionQueryBuilderDsl>(p, ProductSetProductPriceCustomFieldActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
