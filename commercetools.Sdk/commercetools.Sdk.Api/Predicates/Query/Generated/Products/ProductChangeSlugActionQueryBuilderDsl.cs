using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Products
{

    public partial class ProductChangeSlugActionQueryBuilderDsl
    {
        public ProductChangeSlugActionQueryBuilderDsl()
        {
        }

        public static ProductChangeSlugActionQueryBuilderDsl Of()
        {
            return new ProductChangeSlugActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductChangeSlugActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<ProductChangeSlugActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<ProductChangeSlugActionQueryBuilderDsl>(p, ProductChangeSlugActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ProductChangeSlugActionQueryBuilderDsl> Slug(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductChangeSlugActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("slug"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl.Of())),
                ProductChangeSlugActionQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<ProductChangeSlugActionQueryBuilderDsl, bool> Staged()
        {
            return new ComparisonPredicateBuilder<ProductChangeSlugActionQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("staged")),
            p => new CombinationQueryPredicate<ProductChangeSlugActionQueryBuilderDsl>(p, ProductChangeSlugActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
