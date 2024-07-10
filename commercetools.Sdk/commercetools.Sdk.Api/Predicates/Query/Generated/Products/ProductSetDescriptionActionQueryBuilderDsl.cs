using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Products
{

    public partial class ProductSetDescriptionActionQueryBuilderDsl
    {
        public ProductSetDescriptionActionQueryBuilderDsl()
        {
        }

        public static ProductSetDescriptionActionQueryBuilderDsl Of()
        {
            return new ProductSetDescriptionActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductSetDescriptionActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<ProductSetDescriptionActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<ProductSetDescriptionActionQueryBuilderDsl>(p, ProductSetDescriptionActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ProductSetDescriptionActionQueryBuilderDsl> Description(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductSetDescriptionActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("description"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl.Of())),
                ProductSetDescriptionActionQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<ProductSetDescriptionActionQueryBuilderDsl, bool> Staged()
        {
            return new ComparisonPredicateBuilder<ProductSetDescriptionActionQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("staged")),
            p => new CombinationQueryPredicate<ProductSetDescriptionActionQueryBuilderDsl>(p, ProductSetDescriptionActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
