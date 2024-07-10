using System;
using commercetools.Sdk.Api.Predicates.Query;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.Stores
{

    public partial class StoreChangeProductSelectionActionQueryBuilderDsl
    {
        public StoreChangeProductSelectionActionQueryBuilderDsl()
        {
        }

        public static StoreChangeProductSelectionActionQueryBuilderDsl Of()
        {
            return new StoreChangeProductSelectionActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<StoreChangeProductSelectionActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<StoreChangeProductSelectionActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<StoreChangeProductSelectionActionQueryBuilderDsl>(p, StoreChangeProductSelectionActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<StoreChangeProductSelectionActionQueryBuilderDsl> ProductSelection(
            Func<commercetools.Sdk.Api.Predicates.Query.ProductSelections.ProductSelectionResourceIdentifierQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.ProductSelections.ProductSelectionResourceIdentifierQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StoreChangeProductSelectionActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("productSelection"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.ProductSelections.ProductSelectionResourceIdentifierQueryBuilderDsl.Of())),
                StoreChangeProductSelectionActionQueryBuilderDsl.Of);
        }

        public IComparisonPredicateBuilder<StoreChangeProductSelectionActionQueryBuilderDsl, bool> Active()
        {
            return new ComparisonPredicateBuilder<StoreChangeProductSelectionActionQueryBuilderDsl, bool>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("active")),
            p => new CombinationQueryPredicate<StoreChangeProductSelectionActionQueryBuilderDsl>(p, StoreChangeProductSelectionActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }

    }
}
