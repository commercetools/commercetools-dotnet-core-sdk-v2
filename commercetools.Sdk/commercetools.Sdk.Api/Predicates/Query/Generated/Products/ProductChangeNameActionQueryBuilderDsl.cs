using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Products
{

    public partial class ProductChangeNameActionQueryBuilderDsl
    {
        public ProductChangeNameActionQueryBuilderDsl()
        {
        }

        public static ProductChangeNameActionQueryBuilderDsl Of()
        {
            return new ProductChangeNameActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductChangeNameActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<ProductChangeNameActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<ProductChangeNameActionQueryBuilderDsl>(p, ProductChangeNameActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ProductChangeNameActionQueryBuilderDsl> Name(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductChangeNameActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("name"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl.Of())),
                ProductChangeNameActionQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<ProductChangeNameActionQueryBuilderDsl, bool> Staged()
        {
            return new ComparisonPredicateBuilder<ProductChangeNameActionQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("staged")),
            p => new CombinationQueryPredicate<ProductChangeNameActionQueryBuilderDsl>(p, ProductChangeNameActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
