using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ProductSelections
{

    public partial class ProductSelectionChangeNameActionQueryBuilderDsl
    {
        public ProductSelectionChangeNameActionQueryBuilderDsl()
        {
        }

        public static ProductSelectionChangeNameActionQueryBuilderDsl Of()
        {
            return new ProductSelectionChangeNameActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductSelectionChangeNameActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<ProductSelectionChangeNameActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<ProductSelectionChangeNameActionQueryBuilderDsl>(p, ProductSelectionChangeNameActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ProductSelectionChangeNameActionQueryBuilderDsl> Name(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductSelectionChangeNameActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("name"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl.Of())),
                ProductSelectionChangeNameActionQueryBuilderDsl.Of);
        }


    }
}
