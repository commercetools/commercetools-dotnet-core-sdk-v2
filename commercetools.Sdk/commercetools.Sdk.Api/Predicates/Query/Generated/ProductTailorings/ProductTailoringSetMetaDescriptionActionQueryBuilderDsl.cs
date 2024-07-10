using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ProductTailorings
{

    public partial class ProductTailoringSetMetaDescriptionActionQueryBuilderDsl
    {
        public ProductTailoringSetMetaDescriptionActionQueryBuilderDsl()
        {
        }

        public static ProductTailoringSetMetaDescriptionActionQueryBuilderDsl Of()
        {
            return new ProductTailoringSetMetaDescriptionActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductTailoringSetMetaDescriptionActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<ProductTailoringSetMetaDescriptionActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<ProductTailoringSetMetaDescriptionActionQueryBuilderDsl>(p, ProductTailoringSetMetaDescriptionActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ProductTailoringSetMetaDescriptionActionQueryBuilderDsl> MetaDescription(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductTailoringSetMetaDescriptionActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("metaDescription"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl.Of())),
                ProductTailoringSetMetaDescriptionActionQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<ProductTailoringSetMetaDescriptionActionQueryBuilderDsl, bool> Staged()
        {
            return new ComparisonPredicateBuilder<ProductTailoringSetMetaDescriptionActionQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("staged")),
            p => new CombinationQueryPredicate<ProductTailoringSetMetaDescriptionActionQueryBuilderDsl>(p, ProductTailoringSetMetaDescriptionActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
