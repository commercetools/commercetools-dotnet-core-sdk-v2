using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Stores
{

    public partial class StoreAddProductSelectionActionQueryBuilderDsl
    {
        public StoreAddProductSelectionActionQueryBuilderDsl()
        {
        }

        public static StoreAddProductSelectionActionQueryBuilderDsl Of()
        {
            return new StoreAddProductSelectionActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<StoreAddProductSelectionActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<StoreAddProductSelectionActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<StoreAddProductSelectionActionQueryBuilderDsl>(p, StoreAddProductSelectionActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<StoreAddProductSelectionActionQueryBuilderDsl> ProductSelection(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductSelections.ProductSelectionResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductSelections.ProductSelectionResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StoreAddProductSelectionActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("productSelection"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductSelections.ProductSelectionResourceIdentifierQueryBuilderDsl.Of())),
                StoreAddProductSelectionActionQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<StoreAddProductSelectionActionQueryBuilderDsl, bool> Active()
        {
            return new ComparisonPredicateBuilder<StoreAddProductSelectionActionQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("active")),
            p => new CombinationQueryPredicate<StoreAddProductSelectionActionQueryBuilderDsl>(p, StoreAddProductSelectionActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
