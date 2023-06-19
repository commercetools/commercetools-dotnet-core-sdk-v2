using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Products
{

    public partial class ProductSetMetaDescriptionActionQueryBuilderDsl
    {
        public ProductSetMetaDescriptionActionQueryBuilderDsl()
        {
        }

        public static ProductSetMetaDescriptionActionQueryBuilderDsl Of()
        {
            return new ProductSetMetaDescriptionActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductSetMetaDescriptionActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<ProductSetMetaDescriptionActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<ProductSetMetaDescriptionActionQueryBuilderDsl>(p, ProductSetMetaDescriptionActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ProductSetMetaDescriptionActionQueryBuilderDsl> MetaDescription(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductSetMetaDescriptionActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("metaDescription"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl.Of())),
                ProductSetMetaDescriptionActionQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<ProductSetMetaDescriptionActionQueryBuilderDsl, bool> Staged()
        {
            return new ComparisonPredicateBuilder<ProductSetMetaDescriptionActionQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("staged")),
            p => new CombinationQueryPredicate<ProductSetMetaDescriptionActionQueryBuilderDsl>(p, ProductSetMetaDescriptionActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
