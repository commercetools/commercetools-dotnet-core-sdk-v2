using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ProductTailorings
{

    public partial class ProductTailoringSetSlugActionQueryBuilderDsl
    {
        public ProductTailoringSetSlugActionQueryBuilderDsl()
        {
        }

        public static ProductTailoringSetSlugActionQueryBuilderDsl Of()
        {
            return new ProductTailoringSetSlugActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductTailoringSetSlugActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<ProductTailoringSetSlugActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<ProductTailoringSetSlugActionQueryBuilderDsl>(p, ProductTailoringSetSlugActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ProductTailoringSetSlugActionQueryBuilderDsl> Slug(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductTailoringSetSlugActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("slug"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl.Of())),
                ProductTailoringSetSlugActionQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<ProductTailoringSetSlugActionQueryBuilderDsl, bool> Staged()
        {
            return new ComparisonPredicateBuilder<ProductTailoringSetSlugActionQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("staged")),
            p => new CombinationQueryPredicate<ProductTailoringSetSlugActionQueryBuilderDsl>(p, ProductTailoringSetSlugActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
