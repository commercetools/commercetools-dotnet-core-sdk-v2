using System;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Predicates.Query.OrderEdits
{

    public partial class StagedOrderImportLineItemStateActionQueryBuilderDsl
    {
        public StagedOrderImportLineItemStateActionQueryBuilderDsl()
        {
        }

        public static StagedOrderImportLineItemStateActionQueryBuilderDsl Of()
        {
            return new StagedOrderImportLineItemStateActionQueryBuilderDsl();
        }

        public IComparisonPredicateBuilder<StagedOrderImportLineItemStateActionQueryBuilderDsl, string> Action()
        {
            return new ComparisonPredicateBuilder<StagedOrderImportLineItemStateActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("action")),
            p => new CombinationQueryPredicate<StagedOrderImportLineItemStateActionQueryBuilderDsl>(p, StagedOrderImportLineItemStateActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public IComparisonPredicateBuilder<StagedOrderImportLineItemStateActionQueryBuilderDsl, string> LineItemId()
        {
            return new ComparisonPredicateBuilder<StagedOrderImportLineItemStateActionQueryBuilderDsl, string>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("lineItemId")),
            p => new CombinationQueryPredicate<StagedOrderImportLineItemStateActionQueryBuilderDsl>(p, StagedOrderImportLineItemStateActionQueryBuilderDsl.Of),
            PredicateFormatter.Format);
        }
        public CombinationQueryPredicate<StagedOrderImportLineItemStateActionQueryBuilderDsl> State(
            Func<commercetools.Sdk.Api.Predicates.Query.Orders.ItemStateQueryBuilderDsl, CombinationQueryPredicate<commercetools.Sdk.Api.Predicates.Query.Orders.ItemStateQueryBuilderDsl>> fn)
        {
            return new CombinationQueryPredicate<StagedOrderImportLineItemStateActionQueryBuilderDsl>(ContainerQueryPredicate.Of()
                .Parent(ConstantQueryPredicate.Of().Constant("state"))
                .Inner(fn.Invoke(commercetools.Sdk.Api.Predicates.Query.Orders.ItemStateQueryBuilderDsl.Of())),
                StagedOrderImportLineItemStateActionQueryBuilderDsl.Of);
        }
        public ICollectionPredicateBuilder<StagedOrderImportLineItemStateActionQueryBuilderDsl> State()
        {
            return new CollectionPredicateBuilder<StagedOrderImportLineItemStateActionQueryBuilderDsl>(BinaryQueryPredicate.Of().Left(new ConstantQueryPredicate("state")),
                    p => new CombinationQueryPredicate<StagedOrderImportLineItemStateActionQueryBuilderDsl>(p, StagedOrderImportLineItemStateActionQueryBuilderDsl.Of));
        }

    }
}
