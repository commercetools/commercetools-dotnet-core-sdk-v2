using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Stores
{

    public partial class StoreRemoveProductSelectionActionQueryBuilderDsl
    {
        public StoreRemoveProductSelectionActionQueryBuilderDsl()
        {
        }

        public static StoreRemoveProductSelectionActionQueryBuilderDsl Of()
        {
            return new StoreRemoveProductSelectionActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<StoreRemoveProductSelectionActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<StoreRemoveProductSelectionActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<StoreRemoveProductSelectionActionQueryBuilderDsl>(p, StoreRemoveProductSelectionActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<StoreRemoveProductSelectionActionQueryBuilderDsl> ProductSelection(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductSelections.ProductSelectionResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductSelections.ProductSelectionResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StoreRemoveProductSelectionActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("productSelection"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductSelections.ProductSelectionResourceIdentifierQueryBuilderDsl.Of())),
                StoreRemoveProductSelectionActionQueryBuilderDsl.Of);
        }


    }
}
