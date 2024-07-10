using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.ProductTailorings
{

    public partial class ProductTailoringSetNameActionQueryBuilderDsl
    {
        public ProductTailoringSetNameActionQueryBuilderDsl()
        {
        }

        public static ProductTailoringSetNameActionQueryBuilderDsl Of()
        {
            return new ProductTailoringSetNameActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<ProductTailoringSetNameActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<ProductTailoringSetNameActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<ProductTailoringSetNameActionQueryBuilderDsl>(p, ProductTailoringSetNameActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<ProductTailoringSetNameActionQueryBuilderDsl> Name(
            Func<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<ProductTailoringSetNameActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("name"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Common.LocalizedStringQueryBuilderDsl.Of())),
                ProductTailoringSetNameActionQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<ProductTailoringSetNameActionQueryBuilderDsl, bool> Staged()
        {
            return new ComparisonPredicateBuilder<ProductTailoringSetNameActionQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("staged")),
            p => new CombinationQueryPredicate<ProductTailoringSetNameActionQueryBuilderDsl>(p, ProductTailoringSetNameActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
